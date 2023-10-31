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
                        DropDownList1.Items.Add(new ListItem("Seçenek 1", "1"));
                        DropDownList1.Items.Add(new ListItem("Seçenek 2", "2"));
                        
                    }
               
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;

            if (selectedValue == "1")
            {
                DisplayImage.ImageUrl = "https://cdnuploads.aa.com.tr/uploads/Contents/2023/10/28/thumbs_b_c_6c9fe0272edd00cff81e9f7f198c7ec3.jpg"; // İlk seçenek için resim yolu
            }
            else if (selectedValue == "2")
            {
                DisplayImage.ImageUrl = "https://media.istockphoto.com/id/1164889653/tr/foto%C4%9Fraf/seyhan-nehri-ve-sabanc%C4%B1-camii-adana-t%C3%BCrkiye.jpg?s=612x612&w=0&k=20&c=z4Z15JOradJO-i4UToknh4839y2hHLuIyTNxeZkFDFE="; // İkinci seçenek için resim yolu
            }

            DisplayImage.Visible = true; // Resim görünür hale getirilir
        }
    }
}
