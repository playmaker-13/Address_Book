using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Address_Book.Models;


namespace Address_Book
{
    public partial class _Default : Page
    {
        AddressBookDatabaseContext DbContext { get; set; }

        public _Default()
        {
            DbContext = new AddressBookDatabaseContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Abonent newRecord = DbContext.Abonents.Create();
                newRecord.LastName = LastName.Text;
                newRecord.Name = Name.Text;
                newRecord.Patronymic = Patronymic.Text;
                newRecord.Phone = Phone.Text;
                newRecord.Address = Address.Text;
                DbContext.Abonents.Add(newRecord);
                DbContext.SaveChanges();
                lblStatus.Text = "ID новой записи: " + newRecord.AbonentID;
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }

            //String ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Address_Book.mdf;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(ConnectionString);
            //SqlCommand command = new SqlCommand();
            //command.CommandText = "Insert Into Records (LastName, Name, Patronymic, Phone, Address) Values (@LastName, @Name, @Patronymic, @Phone, @Address)";
            //command.Connection = connection;
            ////command.Parameters.AddWithValue("@RecordID", 10);  // Set the value of the parameter to the value of the textbox.
            //command.Parameters.AddWithValue("@LastName", LastName.Text);
            //command.Parameters.AddWithValue("@Name", Name.Text);
            //command.Parameters.AddWithValue("@Patronymic", Patronymic.Text);
            //command.Parameters.AddWithValue("@Phone", Phone.Text);
            //command.Parameters.AddWithValue("@Address", Address.Text);
                 
            //// Use a try... catch...finally block to ensure the connection is closed properly
            //    try
            //    {
            //       connection.Open();
            //       command.ExecuteNonQuery();
            //       lblStatus.Text = "Item Inserted";
            //    }
            //    catch(Exception ex)
            //    {
            //       lblStatus.Text = ex.ToString();
            //    }
            //    finally
            //    {
            //       connection.Close(); // will happen whether the try is successful or errors out, ensuring your connection is closed properly.
            //    }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Record lastRecord = DbContext.Records.OrderByDescending(r => r.RecordID).FirstOrDefault();
                //if (lastRecord != null)
                //{
                //    lblStatus.Text = "ID последней записи: " + lastRecord.RecordID;
                //}
                //else
                //{
                //    lblStatus.Text = "Таблица пустая";
                //}

                var recID = DbContext.Abonents.OrderByDescending(r => r.AbonentID).Select(r => new { RecordId = r.AbonentID }).FirstOrDefault();
                if (recID != null)
                {
                    lblStatus.Text = "ID последней записи: " + recID.RecordId;
                }
                else
                {
                    lblStatus.Text = "Таблица пустая";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
        }
    }
}