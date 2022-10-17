using System.Data;
using System.Data.SqlClient;

namespace DatabaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Mname, password , Mcode , Venue_Code, Venue_Name, Address, City, Date, Duration,Time, Marks ;
            Console.WriteLine(" Please Enter choice , enter all 3 tables  ");
            string  input = Console.ReadLine();


            if (input == "1")
            {
                Console.WriteLine("***********Database Of Redacademy Sprinters***********************************");
               
                Console.WriteLine(" Please Enter Module Name ");
                Mname = Console.ReadLine();
                Console.WriteLine("Please enter Mcode");
                Mcode  = Console.ReadLine();

                //The server's name that holds the database
                string DataSource = "DESKTOP-LJV9NM1";



                //The name of the database
                string InitialCatalog = "redassessment";



                //Sets if the connection should use integrated security.
                //If this value is set to "SSPI", the user's Windows Authentication will be used
                string IntegratedSecurity = "Yes";



                //Should the database require a specific log in
                string UserID = "DESKTOP-LJV9NM1\\Siphosethu Nikela";

                string Password = "";




                string connectionString = "Data Source =" + DataSource
                    + "; Initial Catalog =" + InitialCatalog
                    + "; Integrated Security=" + IntegratedSecurity
                    //+ "; User ID=" + UserID
                    //+ "; Password=" + Password
                    ;



                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();



                    // select sql command and connection
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM dbo.MODULE", connectionString);
                   //
                   //SqlDataAdapter sqlData5 = new SqlDataAdapter("ELECT * FROM dbo.trip HERE duration >Vue ", connectionString);
                    SqlCommand sqlCommand11 = new SqlCommand("insert into dbo.MODULE values ('" + Mname + "','" + Mcode + "')  ", connection);
                    int i = sqlCommand11.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Console.WriteLine("insertion succesfully ");
                    }


                    // set the data to database
                    DataTable dataT = new DataTable();
                    sqlData.Fill(dataT);
                    foreach (DataRow row in dataT.Rows)
                    {
                        Console.WriteLine(row["MODULE_NAME"]);
                        Console.WriteLine(row["MODULE_CODE"]);
                       
                    }


                    Console.WriteLine("The database has been opened!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());



                    connection.Close();
                    Console.WriteLine("The database has been closed!");



                    connection.Dispose();
                    Console.WriteLine("The database connection has been disposed!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There's an error connecting to the database!\n" + ex.Message);
                }


            }




            if (input == "2")
            {
                Console.WriteLine("Please enter Venue_Code");
                Venue_Code = Console.ReadLine();
                Console.WriteLine("Please enter Venue_Name");
                Venue_Name = Console.ReadLine();
                Console.WriteLine("Please enter Address");
                Address = Console.ReadLine();
                Console.WriteLine("Please enter City");
                City = Console.ReadLine();

                //The server's name that holds the database
                string DataSource = "DESKTOP-LJV9NM1";



                //The name of the database
                string InitialCatalog = "redassessment";



                //Sets if the connection should use integrated security.
                //If this value is set to "SSPI", the user's Windows Authentication will be used
                string IntegratedSecurity = "Yes";



                //Should the database require a specific log in
                string UserID = "DESKTOP-LJV9NM1\\Siphosethu Nikela";

                string Password = "";




                string connectionString = "Data Source =" + DataSource
                    + "; Initial Catalog =" + InitialCatalog
                    + "; Integrated Security=" + IntegratedSecurity
                    //+ "; User ID=" + UserID
                    //+ "; Password=" + Password
                    ;


                try
                {
                    // connecttion fom c# to database 
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * FROM dbo.VENUE", connectionString);
                    //SqlDataAdapter sqlData3 = new SqlDataAdapter("ELECT * FROM dbo.trip HERE duration > Vue", connectionString);
                    SqlCommand sqlCommand33 = new SqlCommand("insert into dbo.VENUE values ('" + Venue_Code + "','" + Venue_Name + "','" + Address + "','" + City + "')  ", connection);


                    int x = sqlCommand33.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Console.WriteLine("insertion succesfully ");
                    }


                    // put data to the table
                    DataTable dataM = new DataTable();
                    sqlData2.Fill(dataM);
                    foreach (DataRow row in dataM.Rows)
                    {
                        //Console.WriteLine(row["VENUE_CODE"]);
                        //Console.WriteLine(row["VENUE_NAME "]);
                        //Console.WriteLine(row["ADDRESS "]);
                        //Console.WriteLine(row["CITY "]);
                        //Console.WriteLine(row["id"]);
                    }

                    Console.WriteLine("The database has been opened!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());



                    connection.Close();
                    Console.WriteLine("The database has been closed!");



                    connection.Dispose();
                    Console.WriteLine("The database connection has been disposed!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());
                }

                catch (Exception ex)
                {
                    Console.WriteLine("There's an error connecting to the database!\n" + ex.Message);
                }

            }

            if (input == "3")
            {
                Console.WriteLine("Please enter Module_Code");
                Mcode = Console.ReadLine();

                Console.WriteLine("Please enter Venue_Code");
                Venue_Code = Console.ReadLine();

                Console.WriteLine("Please enter Date");
                Date = Console.ReadLine();

                Console.WriteLine("Please enter Time");
                Time = Console.ReadLine();

                Console.WriteLine("Please enter Duration");
                Duration = Console.ReadLine();

                Console.WriteLine("Please enter Marks");
                Marks = Console.ReadLine();

                //The server's name that holds the database
                string DataSource = "DESKTOP-LJV9NM1";



                //The name of the database
                string InitialCatalog = "redassessment";



                //Sets if the connection should use integrated security.
                //If this value is set to "SSPI", the user's Windows Authentication will be used
                string IntegratedSecurity = "Yes";



                //Should the database require a specific log in
                string UserID = "DESKTOP-LJV9NM1\\Siphosethu Nikela";

                string Password = "";




                string connectionString = "Data Source =" + DataSource
                    + "; Initial Catalog =" + InitialCatalog
                    + "; Integrated Security=" + IntegratedSecurity
                    //+ "; User ID=" + UserID
                    //+ "; Password=" + Password
                    ;


                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlDataAdapter sqlData3 = new SqlDataAdapter("SELECT * FROM dbo.ASSESSMENT_BOOKINGS", connectionString);
                    SqlDataAdapter sqlData4 = new SqlDataAdapter("ELECT  duration * FROM dbo.trips RDER BY duration DESC IMIT 1; > Vue", connectionString);
                    SqlCommand sqlCommand2 = new SqlCommand("insert into dbo.ASSESSMENT_BOOKINGS values ('" + Mcode + "','" + Venue_Code + "','" + Date + "','" + Time + "','" + Duration + "','" + Marks + "')  ", connection);
                    int Y = sqlCommand2.ExecuteNonQuery();
                    if (Y > 0)
                    {
                        Console.WriteLine("insertion succesfully ");
                    }



                    DataTable dataZ = new DataTable();
                    sqlData3.Fill(dataZ);
                    foreach (DataRow row in dataZ.Rows)
                    {
                        Console.WriteLine(row["MODULE_CODE"]);
                        Console.WriteLine(row["VENUE_CODE"]);
                        Console.WriteLine(row["ASSESSMENT_DATE "]);
                        Console.WriteLine(row["START_TIME "]);
                        Console.WriteLine(row["DURATION "]);
                        Console.WriteLine(row["MARKS"]);
                    }

                    Console.WriteLine("The database has been opened!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());



                    connection.Close();
                    Console.WriteLine("The database has been closed!");



                    connection.Dispose();
                    Console.WriteLine("The database connection has been disposed!");
                    Console.WriteLine("Connection State: " + connection.State.ToString());
                }

                catch (Exception ex)
                {
                    Console.WriteLine("There's an error connecting to the database!\n" + ex.Message);
                }




            }















            


        }
    }
}