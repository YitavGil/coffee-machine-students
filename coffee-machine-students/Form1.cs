using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace coffee_machine_students
{
	public partial class Form1 : Form
	{
		private XmlDocument xmlDoc;
		private string XML_FILE_PATH = $"{Directory.GetCurrentDirectory()}\\drinks.xml";

		public Form1()
		{
			InitializeComponent();
			SetupDataGridView(); // זה חשוב! מגדיר את העמודות ב-DataGridView
			LoadXmlData();
		}

		private void SetupDataGridView()
		{
			// הגדרת העמודות ב-DataGridView
			dgvDrinks.ColumnCount = 6;
			dgvDrinks.Columns[0].Name = "Name"; // שינוי מ-"Drink" ל-"Name"
			dgvDrinks.Columns[1].Name = "Sugar";
			dgvDrinks.Columns[2].Name = "Coffee";
			dgvDrinks.Columns[3].Name = "Cocoa";
			dgvDrinks.Columns[4].Name = "Milk";
			dgvDrinks.Columns[5].Name = "Price";
		}

		private void LoadXmlData()
		{
			xmlDoc = new XmlDocument();

			if (File.Exists(XML_FILE_PATH))
			{
				try
				{
					xmlDoc.Load(XML_FILE_PATH);
					XmlNodeList drinkNodes = xmlDoc.SelectNodes("//Drink");

					foreach (XmlNode drinkNode in drinkNodes)
					{
						string[] row = new string[]
						{
							drinkNode.Attributes["Name"].Value,
							drinkNode.Attributes["Sugar"].Value,
							drinkNode.Attributes["Coffee"].Value,
							drinkNode.Attributes["Cocoa"].Value,
							drinkNode.Attributes["Milk"].Value,
							drinkNode.Attributes["Price"].Value
						};
						dgvDrinks.Rows.Add(row);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"שגיאה בטעינת קובץ XML: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XmlElement root = xmlDoc.CreateElement("Drinks");
				xmlDoc.AppendChild(root);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			XmlElement drinkElement = xmlDoc.CreateElement("Drink");
			drinkElement.SetAttribute("Name", txtDrinkName.Text);
			drinkElement.SetAttribute("Sugar", cmbxSugar.Text);
			drinkElement.SetAttribute("Coffee", cmbCoffee.Text);
			drinkElement.SetAttribute("Cocoa", cmbCocoa.Text);
			drinkElement.SetAttribute("Milk", cmbMilk.Text);
			drinkElement.SetAttribute("Price", txtPrice.Text);

			xmlDoc.DocumentElement.AppendChild(drinkElement);

			string[] row = new string[] {
				txtDrinkName.Text,
				cmbxSugar.Text,
				cmbCoffee.Text,
				cmbCocoa.Text,
				cmbMilk.Text,
				txtPrice.Text
			};
			dgvDrinks.Rows.Add(row);

			ClearInputs();
		}

		private void ClearInputs()
		{
			txtDrinkName.Clear();
			cmbxSugar.Text = "0";
			cmbCoffee.Text = "0";
			cmbCocoa.Text = "0";
			cmbMilk.Text = "0";
			txtPrice.Text = "0";
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvDrinks.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow row in dgvDrinks.SelectedRows)
				{
					string drinkName = row.Cells["Name"].Value.ToString(); // שינוי מ-"Drink" ל-"Name"
					XmlNode nodeToRemove = xmlDoc.SelectSingleNode($"//Drink[@Name='{drinkName}']");
					if (nodeToRemove != null)
					{
						nodeToRemove.ParentNode.RemoveChild(nodeToRemove);
					}

					dgvDrinks.Rows.RemoveAt(row.Index);
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvDrinks.SelectedRows.Count == 1)
			{
				DataGridViewRow row = dgvDrinks.SelectedRows[0];
				string oldDrinkName = row.Cells["Name"].Value.ToString(); // שינוי מ-"Drink" ל-"Name"

				XmlNode nodeToUpdate = xmlDoc.SelectSingleNode($"//Drink[@Name='{oldDrinkName}']");
				if (nodeToUpdate != null)
				{
					nodeToUpdate.Attributes["Name"].Value = txtDrinkName.Text;
					nodeToUpdate.Attributes["Sugar"].Value = cmbxSugar.Text;
					nodeToUpdate.Attributes["Coffee"].Value = cmbCoffee.Text;
					nodeToUpdate.Attributes["Cocoa"].Value = cmbCocoa.Text;
					nodeToUpdate.Attributes["Milk"].Value = cmbMilk.Text;
					nodeToUpdate.Attributes["Price"].Value = txtPrice.Text;

					row.Cells["Name"].Value = txtDrinkName.Text; // שינוי מ-"Drink" ל-"Name"
					row.Cells["Sugar"].Value = cmbxSugar.Text;
					row.Cells["Coffee"].Value = cmbCoffee.Text;
					row.Cells["Cocoa"].Value = cmbCocoa.Text;
					row.Cells["Milk"].Value = cmbMilk.Text;
					row.Cells["Price"].Value = txtPrice.Text;

					ClearInputs();
				}
			}
			else
			{
				MessageBox.Show("אנא בחר שורה אחת לעדכון.", "שגיאת עדכון", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				xmlDoc.Save(XML_FILE_PATH);
				MessageBox.Show("הנתונים נשמרו בהצלחה!", "שמירה", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"שגיאה בשמירת קובץ XML: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}