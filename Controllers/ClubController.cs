using Club.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.Data.SqlClient;
namespace Club.Controllers
{
    /// <Author> ---------------->
    /// James Fehr
    /// <Project>
    /// Club 
    /// <details>
    /// Class project making a Club Member List with Create, Edit and Delete functionality
    /// connected to Local SQL DB
    /// --------------------->
    public class ClubController : Controller
    {
        List<ClubMembers> list = new List<ClubMembers>();
        const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
        public IActionResult Index()
        {
            return View(GetInfoFromDB());
        }
        public static List<ClubMembers> GetInfoFromDB() // Loads and Displays ClubMembers List
        {
            List<ClubMembers> list = new List<ClubMembers>();


            //connection string 
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            // Use connectionString to connect to DB
            using (SqlConnection conn = new SqlConnection(connString))
            {   //Get all ClubMembers
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ClubMembers"))
                {
                    cmd.Connection = conn;
                    conn.Open();    //open a connection to the DB
                    SqlDataReader sdr = cmd.ExecuteReader();    // Start reading data from the DB
                    while (sdr.Read())  // reads thru the DB ClubMembers 
                    {   // Make and instance of ClubMembers
                        ClubMembers clubMembers = new ClubMembers
                        {
                            MemberID = Convert.ToInt32(sdr["MemberID"]),
                            FirstName = sdr["FirstName"].ToString(),
                            LastName = sdr["LastName"].ToString(),
                            Level = sdr["Level"].ToString(),
                            DOB = sdr["DOB"].ToString()
                        };
                        list.Add(clubMembers);  // add clubMember to ist of ClubMembers
                    }
                    sdr.Close();    // Close reader
                    conn.Close();   // Close DB connection
                }

            }


            return list;
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();  // Displays webpage
        }
        [HttpPost]  // Send the Data to the DB
        public ActionResult Create(ClubMembers clubMembers)
        {   // connectionString
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            // sql command string 
            string sql = $"INSERT INTO ClubMembers (MemberID, FirstName, LastName, Level, DOB) Values (@MemberID,@FirstName,@LastName,@Level,@DOB)";
            
            try 
            {   // make a connection to the DB ClubMembers
                using SqlConnection conn = new SqlConnection(connString);
                {
                    conn.Open();    // Open connection to DB ClubMembers
                     using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {   // add updated values of member to DB using parameters
                        cmd.Parameters.AddWithValue("@MemberID", clubMembers.MemberID);
                        cmd.Parameters.AddWithValue("@FirstName", clubMembers.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", clubMembers.LastName);
                        cmd.Parameters.AddWithValue("@Level", clubMembers.Level);
                        cmd.Parameters.AddWithValue("@DOB", clubMembers.DOB);
                        cmd.ExecuteNonQuery();  // Make it so Jim!
                    }
                }
            }
            catch (Exception ex)
            {
                // show an error message
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                return View(clubMembers);
            }
            return View("Index", GetInfoFromDB());

        }
        [HttpGet]


        public ActionResult Edit(int id)
        {   // connectionString to DB ClubMembers
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            ClubMembers clubMembers = new ClubMembers();  // make a list object to hold ClubMembers
            try
            {   // try to setup connection to DB ClubMembers
                using (SqlConnection conn = new SqlConnection(connString))
                {   // get selected ClubMember based on MemberID
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                    {   // setup db connection
                        cmd.Connection = conn;
                        conn.Open();    // open connection to ClubMembers DB
                        SqlDataReader sdr = cmd.ExecuteReader();    // start reader
                        while (sdr.Read())  
                        {   // gets all properties of member being edited
                            clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                            clubMembers.FirstName = sdr["FirstName"].ToString();
                            clubMembers.LastName = sdr["LastName"].ToString();
                            clubMembers.Level = sdr["Level"].ToString();
                            clubMembers.DOB = sdr["DOB"].ToString();


                        }
                        sdr.Close();    // Close reader
                        conn.Close();   // Close connection
                    }

                }
                
            }
            catch (Exception ex)
            {   // check for errors and send message if there is one
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View(clubMembers);
            //return View("Index", GetInfoFromDB());  // go back to Member List
        }
        [HttpPost]
        public ActionResult Edit(int MemberID, ClubMembers clubMembers)
        {
            string sql = $"UPDATE ClubMembers Set " +
                $"FirstName = @FirstName, " +
                $"LastName = @LastName, " +
                $"Level = @Level, " +
                $"DOB = @DOB " +
                $"WHERE MemberID = '{clubMembers.MemberID}'; ";

            const string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {   // make connection object to ClubMembers DB
                using (SqlConnection connobj = new SqlConnection(conn))
                {
                    connobj.Open(); // Open connection to ClubMembers DB
                    using (SqlCommand cmd = new SqlCommand(sql, connobj))
                    {   // add updated values of member to DB using parameters
                        cmd.Parameters.AddWithValue("@MemberID", clubMembers.MemberID);
                        cmd.Parameters.AddWithValue("@FirstName", clubMembers.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", clubMembers.LastName);
                        cmd.Parameters.AddWithValue("@Level", clubMembers.Level);
                        cmd.Parameters.AddWithValue("@DOB", clubMembers.DOB);
                        cmd.ExecuteNonQuery();
                    }
                    
                }
            }
            catch(SqlException ex)
            {   // Cleck for errors if found display Error Message
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            //return View();
            return View("Index", GetInfoFromDB());  // Show memberList and display ClubMembers
        }
        [HttpGet]   // get data from the DB ClubMembers
        public ActionResult Delete(int id)
        {   // connection string to ClubMembers
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            // create Member Object clubMembers
            ClubMembers clubMembers = new ClubMembers();
            try 
            {   //setup connection to the DB ClubMembers
                using (SqlConnection conn = new SqlConnection(connString))
                {   // get the specific clubMember based on MemberID
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                    {
                        cmd.Connection = conn;
                        conn.Open();    // open connection to ClubMembers DB
                        SqlDataReader sdr = cmd.ExecuteReader();    // start reader reading
                        while (sdr.Read())
                        {
                            clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                            clubMembers.FirstName = sdr["FirstName"].ToString();
                            clubMembers.LastName = sdr["LastName"].ToString();
                            clubMembers.Level = sdr["Level"].ToString();
                            clubMembers.DOB = sdr["DOB"].ToString();


                        }
                        sdr.Close();    // close SQL reader
                        conn.Close();   // close connection to ClubMembers DB
                    }
                }
            }
            catch(SqlException ex) 
            {   // danger danger will wobinson we have an error so please check what pops up
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                
            }
            return View(clubMembers); // back to the Index
        }
        [HttpPost]
        public ActionResult Delete(int id, ClubMembers clubmembers)
        {   // connection string to ClubMembers DB/Table
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {   // try to open a connection to ClubMembers DB Table and get Member based on MemberID
                using (SqlConnection conn = new SqlConnection(connString))
                {   //Delete ClubMember based on MemberID
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM ClubMembers WHERE MemberID = '{id}'"))
                    {
                        cmd.Connection = conn;
                        conn.Open();    // Open connection to ClubMembers DB Table
                        cmd.ExecuteNonQuery();  // delete ClubMember using PK MemberID
                        conn.Close();   // Close connection to ClubMembers DB Table
                    }

                }
            }
            catch (SqlException ex)
            {   // we have a problem captain look an Error!
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View("Index", GetInfoFromDB());  // back to Index
        }

        public ActionResult Details(int id)
        {   // connection string to ClubMembers DB Table
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            ClubMembers clubMembers = new ClubMembers(); // make a ClubMember Object
            // setup connection to ClubMembers DB Table
            using (SqlConnection conn = new SqlConnection(connString))
            {   // select a ClubMember based on their MemberID 
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                {
                    cmd.Connection = conn;  // setup connection
                    conn.Open();    // open connection to ClubMembers DB Table
                    SqlDataReader sdr = cmd.ExecuteReader();    // start reader
                    while (sdr.Read())  // read details of Member
                    {
                        clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                        clubMembers.FirstName = sdr["FirstName"].ToString();
                        clubMembers.LastName = sdr["LastName"].ToString();
                        clubMembers.Level = sdr["Level"].ToString();
                        clubMembers.DOB = sdr["DOB"].ToString();


                    }
                    sdr.Close();    // Close reader
                    conn.Close();   // Close connection to ClubMembers DB Table
                }

            }
            return View(clubMembers);    // Show clubMembers object
        }
    }
}




