using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace HomeWorkOne
{
    public partial class MyPictures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                    if (!IsPostBack)
                    {
                        DropDownList1.Items.Add(new ListItem("Choose", "0"));
                        DropDownList1.Items.Add(new ListItem("Antalya", "1"));
                        DropDownList1.Items.Add(new ListItem("Mardin", "2"));
                        DropDownList1.Items.Add(new ListItem("Aspendos", "3"));
                        DropDownList1.Items.Add(new ListItem("Muttalip", "4"));
                        DropDownList1.Items.Add(new ListItem("Bursa", "5"));

                    PopulateBorderSizeDropDown();

            }
               
        }

        protected void PopulateBorderSizeDropDown()
        {
            for (int i = 1; i <= 5; i++)
            {
                BorderSizeDropDown.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;

            if (selectedValue == "1")
            {
                DisplayImage.ImageUrl = "https://www.turkeydar.com/assets/img/photo/blg-post_607eb60b523ab.webp"; // İlk seçenek için resim yolu
            }
            else if (selectedValue == "2")
            {
                DisplayImage.ImageUrl = "https://media.istockphoto.com/id/518703264/tr/foto%C4%9Fraf/mardin-turkey.jpg?s=612x612&w=0&k=20&c=F70430SjBMlApuhSk9rXZJm4D2G0Td5uyK76vqAp7BY="; // İkinci seçenek için resim yolu
            }
            else if (selectedValue == "3")
            {
                DisplayImage.ImageUrl = "https://www.sixt.com.tr/storage/images/shares/haberler/aspendos1.jpg"; // İkinci seçenek için resim yolu
            }
            else if (selectedValue == "4")
            {
                DisplayImage.ImageUrl = "https://cdn.iha.com.tr/Contents/images/2023/16/5505546.jpg"; // İkinci seçenek için resim yolu
            }
            else if (selectedValue == "5")
            {
                DisplayImage.ImageUrl = "https://tekce.net/files/upload/images/bh-turkey-bursa-city-real-estate-2.jpg"; // İkinci seçenek için resim yolu
            }


            DisplayImage.Visible = true; // Resim görünür hale getirilir
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                DisplayImage.Style.Add("border", "2px solid red"); // You can adjust the border width and color here
            }
            else
            {
                DisplayImage.Style.Remove("border");
            }
        }

        protected void SetBorderColor()
        {
            string borderColor = "";

            if (RedCheckBox.Checked)
            {
                borderColor = "red";
            }
            else if (BrownCheckBox.Checked)
            {
                borderColor = "#964B00"; // Hex color for brown
            }
            else if (BlueCheckBox.Checked)
            {
                borderColor = "blue";
            }
            else if (GreenCheckBox.Checked)
            {
                borderColor = "green";
            }

            if (!string.IsNullOrEmpty(borderColor))
            {
                DisplayImage.Style.Add("border", $"2px solid {borderColor}");
            }
            else
            {
                DisplayImage.Style.Remove("border");
            }
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBorderColor();
        }

        protected void SetBorderSize()
        {
            string borderSize = BorderSizeDropDown.SelectedValue;

            if (!string.IsNullOrEmpty(borderSize))
            {
                DisplayImage.Style.Add("border-width", $"{borderSize}px");
            }
            else
            {
                DisplayImage.Style.Remove("border-width");
            }
        }

        protected void BorderSizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBorderSize();
        }
    }
}
