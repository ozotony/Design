using ba2xai_cldds_backupModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;
using System.Threading;
using System.Net.Mail;
public class pt
{
	public class Address
	{
		public string city;
		public string countryID;
		public string email1;
		public string email2;
		public string ID;
		public string lgaID;
		public string log_staff;
		public string reg_date;
		public string stateID;
		public string street;
		public string telephone1;
		public string telephone2;
		public string visible;
		public string zip;
	}
	public class AddressService
	{
		public string city;
		public string countryID;
		public string email1;
		public string email2;
		public string ID;
		public string lgaID;
		public string log_staff;
		public string reg_date;
		public string stateID;
		public string street;
		public string telephone1;
		public string telephone2;
		public string visible;
		public string zip;
	}
	public class Applicant
	{
		public string ID;
		public string xname;
		public string address;
		public string xemail;
		public string xmobile;
		public string log_staff;
		public string visible;
	}
	public class Assignment_info
	{
		public string ID;
		public string assignee_name;
		public string assignee_address;
		public string assignor_name;
		public string assignor_address;
		public string log_staff;
		public string visible;
	}
	public class Inventor
	{
		public string ID;
		public string xname;
		public string address;
		public string xemail;
		public string xmobile;
		public string log_staff;
		public string visible;
	}
	public class Country
	{
		public string code;
		public string ID;
		public string name;
	}
	public class Lga
	{
		public string ID;
		public string name;
		public string stateID;
	}
	public class NClass
	{
		public string xdescription;
		public string xID;
		public string xtype;
	}
	public class PtInfo
	{
		public string xID;
		public string reg_number;
		public string xtype;
		public string title_of_invention;
		public string pt_class;
		public string loa_doc;
		public string doa_doc;
		public string ns_doc;
		public string pd_doc;
		public string rep_pic;
		public string rep2_pic;
		public string rep3_pic;
		public string rep4_pic;
		public string log_staff;
		public string reg_date;
		public string xvisible;
	}
	public class Priority_info
	{
		public string xID;
		public string countryID;
		public string app_no;
		public string xdate;
		public string log_staff;
		public string xvisible;
	}
	public class Representative
	{
		public string ID;
		public string agent_code;
		public string xname;
		public string nationality;
		public string country;
		public string state;
		public string address;
		public string xemail;
		public string xmobile;
		public string log_staff;
		public string reg_date;
		public string visible;
	}
	public class Stage
	{
		public string amt;
		public string applicantID;
		public string data_status;
		public string ID;
		public string reg_date;
		public string stage;
		public string status;
		public string validationID;
	}
	public class State
	{
		public string countryID;
		public string ID;
		public string name;
	}
	public string Connect()
	{
		return ConfigurationManager.ConnectionStrings["cldConnectionString"].ConnectionString;
	}

    public string Connect2()
    {
        return ConfigurationManager.ConnectionStrings["xhomeConnectionString"].ConnectionString;
    }
    public string doUploadDoc2(string ID, string path, HttpPostedFile fu)
    {
        try
        {
            if (!Directory.Exists(path + ID + "/"))
            {
                Directory.CreateDirectory(path + ID + "/");
            }
            string str = Path.GetFileName(fu.FileName).Replace(" ", "_");
            fu.SaveAs(path + ID + "/" + str);
            return (path + ID + "/" + str);
        }
        catch (Exception)
        {
            return "";
        }
    }
    public string doUploadDoc(string ID, string path, FileUpload fu)
	{
		string result;
		try
		{
			if (!Directory.Exists(path + ID + "/"))
			{
				Directory.CreateDirectory(path + ID + "/");
			}
			string str2 = Path.GetFileName(fu.FileName).Replace(" ", "_");
			fu.SaveAs(path + ID + "/" + str2);
			result = path + ID + "/" + str2;
		}
		catch (Exception)
		{
			result = "";
		}
		return result;
	}
	public string doUploadDocNoLimit(string ID, string path, FileUpload fu)
	{
		string result;
		try
		{
			if (!Directory.Exists(path + ID + "/"))
			{
				Directory.CreateDirectory(path + ID + "/");
			}
			string str2 = Path.GetFileName(fu.FileName).Replace(" ", "_");
			fu.SaveAs(path + ID + "/" + str2);
			result = path + ID + "/" + str2;
		}
		catch (Exception exception)
		{
			result = "The file could not be uploaded. The following error occured: " + exception.Message;
		}
		return result;
	}
	public string doUploadPic(string ID, string newfilename, string path, FileUpload fu)
	{
		string result;
		try
		{
			if (!Directory.Exists(path + ID + "/"))
			{
				Directory.CreateDirectory(path + ID + "/");
			}
			newfilename = newfilename.Replace(" ", "_");
			fu.SaveAs(path + ID + "/" + newfilename);
			result = path + ID + "/" + newfilename;
		}
		catch (Exception exception)
		{
			result = "The file could not be uploaded. The following error occured: " + exception.Message;
		}
		return result;
	}
	public List<pt.Address> getAddressByID(string ID)
	{
		List<pt.Address> list = new List<pt.Address>();
		new pt.Address();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM address WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Address item = new pt.Address
			{
				ID = reader["ID"].ToString(),
				countryID = reader["countryID"].ToString(),
				stateID = reader["stateID"].ToString(),
				lgaID = reader["lgaID"].ToString(),
				city = reader["city"].ToString(),
				street = reader["street"].ToString(),
				zip = reader["zip"].ToString(),
				telephone1 = reader["telephone1"].ToString(),
				telephone2 = reader["telephone2"].ToString(),
				email1 = reader["email1"].ToString(),
				email2 = reader["email2"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}

    public List<Email4> getEmails()
    {

        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT Admin_Mail.id,Admin_Mail.Subject,Admin_Mail.Message,Admin_Mail.Date_Sent,pwallet.validationid,pwallet.data_status,Admin_Mail.Agent_Code,Admin_Mail.Status,pt_info.title_of_invention,pt_id,pt_info.reg_number FROM Admin_Mail inner join pt_info on Admin_Mail.pt_id = pt_info.xid inner join  pwallet on pt_info.log_staff = pwallet.id order by Date_Sent desc  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        List<Email4> dd = new List<Email4>();
        while (reader.Read())
        {
            Email4 x = new Email4();
            x.id = Convert.ToInt32(reader["id"]);
            x.Subject = reader["Subject"].ToString();
            x.Message = reader["Message"].ToString();
            try
            {
                x.Sent_Date = (reader["Date_Sent"]).ToString();

            }

            catch (Exception ee)
            {

            }

            x.Agent_Code = reader["Agent_Code"].ToString();
            x.Status = Convert.ToBoolean(reader["Status"]);
            x.pt_id = reader["pt_id"].ToString();
            x.reg_number = reader["reg_number"].ToString();
            x.Data_Status = reader["data_status"].ToString();
            x.Title = reader["title_of_invention"].ToString();
            x.Online_Id = reader["validationid"].ToString();
            dd.Add(x);

        }
        reader.Close();
        return dd;
    }

    public Email4 getEmail2(string xid)
    {

        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM Admin_Mail WHERE id='" + xid + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        List<Email4> dd = new List<Email4>();
        Email4 x = new Email4();
        while (reader.Read())
        {

            x.id = Convert.ToInt32(reader["id"]);
            x.Subject = reader["Subject"].ToString();
            x.Message = reader["Message"].ToString();
            try
            {
                x.Sent_Date = (reader["Date_Sent"]).ToString();

            }

            catch (Exception ee)
            {

            }

            x.Agent_Code = reader["Agent_Code"].ToString();

            x.pt_id = reader["pt_id"].ToString();
            x.reg_number = reader["reg_number"].ToString();
            x.Data_Status = getStageByUserID2(x.pt_id)[0].data_status;
            //  dd.Add(x);

        }
        reader.Close();
        updateEmail(xid);
        return x;
    }

    public List<Email4> getOutboxEmails()
    {

        SqlConnection connection = new SqlConnection(this.Connect2());
        SqlCommand command = new SqlCommand("SELECT id,Subject,Message,Date_Sent,agent_code,pt_id   FROM Agent_Mail where subject in ('Design Examiner  Information','Design Search  Information') order by Date_Sent desc  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        List<Email4> dd = new List<Email4>();
        while (reader.Read())
        {
            Email4 x = new Email4();
            x.id = Convert.ToInt32(reader["id"]);
            x.Subject = reader["Subject"].ToString();
            x.Message = reader["Message"].ToString();
            try
            {
                x.Sent_Date = (reader["Date_Sent"]).ToString();

            }

            catch (Exception ee)
            {

            }
            x.Agent_Code = reader["agent_code"].ToString();
            String vpt_id = reader["pt_id"].ToString();

            List<PtInfo> dx = getPtInfoByPwalletID(vpt_id);

            List<Stage> dx2 = getStageByUserID2(dx[0].xID);

            x.Title = dx[0].title_of_invention;
            x.Online_Id = dx2[0].validationID;

            dd.Add(x);

        }
        reader.Close();
        return dd;
    }

    public Email4 getOutboxEmail2(string xid)
    {

        SqlConnection connection = new SqlConnection(this.Connect2());
        SqlCommand command = new SqlCommand("SELECT * FROM Agent_Mail WHERE id='" + xid + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        List<Email4> dd = new List<Email4>();
        Email4 x = new Email4();
        while (reader.Read())
        {

            x.id = Convert.ToInt32(reader["id"]);
            x.Subject = reader["Subject"].ToString();
            x.Message = reader["Message"].ToString();
            try
            {
                x.Sent_Date = (reader["Date_Sent"]).ToString();

            }

            catch (Exception ee)
            {

            }

            x.Agent_Code = reader["Agent_Code"].ToString();


            //  dd.Add(x);

        }
        reader.Close();
        //  updateEmail(xid);
        return x;
    }

    public List<String> getEmailCount4(string status, string data_status)
    {
        String succ = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = false;
        List<String> jj = new List<string>();
        SqlCommand command = new SqlCommand("select 'OAI/DS/'+pwallet.validationid   AS cnt from Admin_Mail inner join pt_info on Admin_Mail.pt_id = pt_info.xid inner join  pwallet on pt_info.log_staff = pwallet.id where  pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "'  and   Admin_Mail.Status ='" + bb + "'   ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            try
            {
                succ = Convert.ToString(reader["cnt"]);
                jj.Add(succ);
            }
            catch (Exception ex)
            {
                succ = "";
            }
        }
        reader.Close();
        return jj;
    }

    public List<Stage> getStageByUserIDAdmin(string validationID)
    {
        List<Stage> list = new List<Stage>();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pwallet WHERE validationID='" + validationID + "'  AND data_status <>'' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            Stage item = new Stage
            {
                ID = reader["ID"].ToString(),
                applicantID = reader["applicantID"].ToString(),
                validationID = reader["validationID"].ToString(),
                stage = reader["stage"].ToString(),
                status = reader["status"].ToString(),
                data_status = reader["data_status"].ToString(),
                amt = reader["amt"].ToString(),
                reg_date = reader["reg_date"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;
    }

    public String getEmailCount3(string status, string data_status)
    {
        int succ = 0;
        String succ2 = null;
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = false;
        SqlCommand command = new SqlCommand("select count(Admin_Mail.id) AS cnt from Admin_Mail inner join pt_info on Admin_Mail.pt_id = pt_info.xid inner join  pwallet on pt_info.log_staff = pwallet.id  where  pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' and Admin_Mail.Status ='" + bb + "'   ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            try
            {
                succ = Convert.ToInt32(reader["cnt"]);
            }
            catch (Exception ex)
            {
                succ = 0;
            }
        }
        reader.Close();
        if (succ > 0)
        {

            succ2 = succ + " UNREAD NOTIFICATIONS";
        }

        else
        {
            succ2 = null;
        }

        return succ2;
    }

    public int getEmailCount2(string status, string data_status)
    {
        int succ = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = false;
        SqlCommand command = new SqlCommand("select count(Admin_Mail.id) AS cnt from Admin_Mail inner join pt_info on Admin_Mail.pt_id = pt_info.xid inner join  pwallet on pt_info.log_staff = pwallet.id where  pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' and   Admin_Mail.Status ='" + bb + "'   ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            try
            {
                succ = Convert.ToInt32(reader["cnt"]);
            }
            catch (Exception ex)
            {
                succ = 0;
            }
        }
        reader.Close();
        return succ;
    }
    public int updateEmail(string xid)
    {
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = true;
        SqlCommand command = new SqlCommand("UPDATE Admin_Mail  SET Status= '" + bb + "'   WHERE id='" + xid + "'  ", connection);
        connection.Open();
        int num = command.ExecuteNonQuery();
        connection.Close();
        return num;
    }
    public List<Stage> getStageByUserID2(string ID)
    {
        List<Stage> list = new List<Stage>();
        new Stage();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pwallet WHERE ID= (select log_staff from pt_info where xid='" + ID + "') ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            Stage item = new Stage
            {
                ID = reader["ID"].ToString(),
                applicantID = reader["applicantID"].ToString(),
                validationID = reader["validationID"].ToString(),
                stage = reader["stage"].ToString(),
                status = reader["status"].ToString(),
                amt = reader["amt"].ToString(),
                reg_date = reader["reg_date"].ToString(),
                data_status = reader["data_status"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;
    }
    public List<pt.Address> getAddressByLog_staffID(string validationID)
	{
		List<pt.Address> list = new List<pt.Address>();
		new pt.Address();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM address WHERE ID='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Address item = new pt.Address
			{
				ID = reader["ID"].ToString(),
				countryID = reader["countryID"].ToString(),
				stateID = reader["stateID"].ToString(),
				lgaID = reader["lgaID"].ToString(),
				city = reader["city"].ToString(),
				street = reader["street"].ToString(),
				zip = reader["zip"].ToString(),
				telephone1 = reader["telephone1"].ToString(),
				telephone2 = reader["telephone2"].ToString(),
				email1 = reader["email1"].ToString(),
				email2 = reader["email2"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.AddressService> getAddressServiceByID(string ID)
	{
		List<pt.AddressService> list = new List<pt.AddressService>();
		new pt.AddressService();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM address_service WHERE log_staff='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.AddressService item = new pt.AddressService
			{
				ID = Convert.ToInt64(reader["ID"]).ToString(),
				countryID = reader["countryID"].ToString(),
				stateID = reader["stateID"].ToString(),
				lgaID = reader["lgaID"].ToString(),
				city = reader["city"].ToString(),
				street = reader["street"].ToString(),
				zip = reader["zip"].ToString(),
				telephone1 = reader["telephone1"].ToString(),
				telephone2 = reader["telephone2"].ToString(),
				email1 = reader["email1"].ToString(),
				email2 = reader["email2"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public bool getAdminExtension(string filename)
	{
		bool flag = false;
		int num = filename.LastIndexOf(".");
		string str = filename.Substring(num + 1);
		return str == "pdf" || str == "jpg" || str == "jpeg" || str == "PDF" || str == "JPG" || str == "JPEG" || flag;
	}
	public string getAgentEmail1ByID(string ID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT email1 FROM address WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["email1"].ToString();
		}
		reader.Close();
		return str;
	}
	public string getAgentTelephone1ByID(string ID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT telephone1 FROM address WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["telephone1"].ToString();
		}
		reader.Close();
		return str;
	}
	public List<pt.Applicant> getApplicantByUserID(string ID)
	{
		List<pt.Applicant> list = new List<pt.Applicant>();
		new pt.Applicant();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM applicant WHERE log_staff='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Applicant item = new pt.Applicant
			{
				ID = reader["ID"].ToString(),
				xname = reader["xname"].ToString(),
				address = reader["address"].ToString(),
				xemail = reader["xemail"].ToString(),
				xmobile = reader["xmobile"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.Applicant> getApplicantByvalidationID(string validationID)
	{
		List<pt.Applicant> list = new List<pt.Applicant>();
		new pt.Applicant();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM applicant WHERE log_staff='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Applicant item = new pt.Applicant
			{
				ID = reader["ID"].ToString(),
				xname = reader["xname"].ToString(),
				address = reader["address"].ToString(),
				xemail = reader["xemail"].ToString(),
				xmobile = reader["xmobile"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.Inventor> getInventorByvalidationID(string validationID)
	{
		List<pt.Inventor> list = new List<pt.Inventor>();
		new pt.Inventor();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM inventor WHERE log_staff='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Inventor item = new pt.Inventor
			{
				ID = reader["ID"].ToString(),
				xname = reader["xname"].ToString(),
				address = reader["address"].ToString(),
				xemail = reader["xemail"].ToString(),
				xmobile = reader["xmobile"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}

public string ConvertTab2Apos(string x)
    {
        string str = x;
        if (((x != null) || (x != "")) && x.Contains("|"))
        {
            str = x.Replace("|", "'");
        }
        return str;
    }

    public string activity_log(string userID, string Module, string Operation, string documentid, string status)
    {
        //  ba2xai_cldx_backupEntities xp = new ba2xai_cldx_backupEntities();
        //  ba2xai_cldx_backupEntities1 app = new ba2xai_cldx_backupEntities1();
        //  activity_lg dd = new activity_lg();
        string str = "";
        string connectionString = Connect();
        //  SqlConnection connection = new SqlConnection(this.Connect());
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd = connection.CreateCommand();
        DateTime currentDate2 = DateTime.UtcNow;
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time");
        currentDate2 = TimeZoneInfo.ConvertTimeFromUtc(currentDate2, pstZone);
        //  currentDate2 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentDate2, TimeZoneInfo.Local.Id, "GMT Standard Time");
        //  TimeSpan currentTime2 = currentDate2.TimeOfDay;



        cmd.CommandText = "INSERT INTO activity_lg (userID,act_date,module,DocumentId,Operation,status) VALUES (@userID,@act_date,@module,@DocumentId,@Operation,@status)";
        connection.Open();
        cmd.Parameters.Add("@userID", SqlDbType.VarChar, 200);
        cmd.Parameters.Add("@DocumentId", SqlDbType.VarChar, 200);
        cmd.Parameters.Add("@Operation", SqlDbType.VarChar, 200);
        cmd.Parameters.Add("@act_date", SqlDbType.DateTime);
        cmd.Parameters.Add("@status", SqlDbType.VarChar, 200);
        //  cmd.Parameters.Add("@act_time", SqlDbType.Timestamp);
        cmd.Parameters.Add("@module", SqlDbType.Text);
        cmd.Parameters["@userID"].Value = userID;
        cmd.Parameters["@act_date"].Value = currentDate2;

        cmd.Parameters["@DocumentId"].Value = documentid;
        cmd.Parameters["@Operation"].Value = Operation;
        cmd.Parameters["@status"].Value = status;
        //  cmd.Parameters["@act_time"].Value = currentTime2;
        cmd.Parameters["@module"].Value = Module;

        foreach (SqlParameter Parameter in cmd.Parameters)
        {
            if (Parameter.Value == null)
            {
                Parameter.Value = DBNull.Value;
            }
        }
        try
        {
            str = cmd.ExecuteScalar().ToString();

        }

        catch (Exception ee)
        {

        }
        connection.Close();
        return str;
    }
    public PtInfo getPtInfoByPwalletID2(string ID)
    {
        List<PtInfo> list = new List<PtInfo>();
        PtInfo item = null;
        new PtInfo();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE log_staff=(select top(1) ID from pwallet where validationID ='" + ID + "' )  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
             item = new PtInfo
            {
               xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
            };
             return item;
           // list.Add(item);
        }
        reader.Close();
        return item;
    }

  public string doUploadDoc2(string ID, string path, FileUpload fu)
    {
        string str = "";
        try
        {
            if (!Directory.Exists(path + ID + "/"))
            {
                Directory.CreateDirectory(path + ID + "/");
            }
            string str2 = Path.GetFileName(fu.FileName).Replace(" ", "_");
            fu.SaveAs(path + ID + "/" + str2);
            return (str = path + ID + "/" + str2);
        }
        catch (Exception)
        {
            return "";
        }
    }
  public string UpdateTrademarkTx(string dd, HttpPostedFile loa_doc, HttpPostedFile ns_doc, HttpPostedFile pd_doc, HttpPostedFile doa_doc, HttpPostedFile rep_pic,HttpPostedFile rep2_pic,HttpPostedFile rep3_pic,HttpPostedFile rep4_pic, string serverpath)
    {
        List<Agent_FileUpload> ts = new List<Agent_FileUpload>();
        PtInfo xxk = getPtInfoByPwalletID2(dd);
       // ptinfobackup(dd);
        updateUploadDate2(dd);

       
      //  cld.Classes.tm.MarkInfo xxk = vtm.getMarkInfoClassByUserID2(dd);

        //  Retriever ret = new Retriever();
        string xID = null; int pID = 0;
        string xloa_doc = ""; string xclaim_doc = ""; string xpct_doc = ""; string xdoa_doc = ""; string xspec_doc = "";
        string reg_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string xtime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        string xvisible = "1"; string xsync = "0";
 string xrep_pic="";
 string xrep2_pic="";string xrep3_pic="";string xrep4_pic="";string xpd_doc=""; string xns_doc="";

        SqlConnection connection; SqlCommand command;
        string connectionString = Connect();
        //c_pwall.reg_date = reg_date;
        //c_pwall.xtime = c_pwall.log_officer + ": " + xtime;
        //c_pwall.visible = xvisible; c_pwall.status = "1"; c_pwall.stage = "5"; c_pwall.data_status = "Fresh";
        //c_pwall.acc_p = "0"; c_pwall.rtm = "0"; 
        int app_addyID = 0;

        int rep_addyID = 0;
        int cert_infoID = 0;



        try
        {



            xID = dd;
            try
            {
                if (loa_doc != null) { xloa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", loa_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (ns_doc != null) { xns_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", ns_doc); }

            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null) { xpd_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", pd_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null) { xdoa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", doa_doc); }

            }
            catch (Exception ee)
            {

            }


            try
            {
                if (rep_pic != null) { xspec_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep_pic); }

            }
            catch (Exception ee)
            {

            }

  try
            {
                if (rep2_pic != null) { xrep2_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep2_pic); }

            }
            catch (Exception ee)
            {

            }

  try
            {
                if (rep3_pic != null) { xrep3_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep3_pic); }

            }
            catch (Exception ee)
            {

            }


  try
            {
                if (rep4_pic != null) { xrep4_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep4_pic); }

            }
            catch (Exception ee)
            {

            }

            try
            {
                if (loa_doc != null)
                {
                    xloa_doc = xloa_doc.Replace(serverpath + "admin/pt/", "");
                    Agent_FileUpload dd3 = new  Agent_FileUpload();
                    dd3.new_file = xloa_doc;
                    dd3.old_file = xxk.loa_doc;
                    ts.Add(dd3);


                }
                else
                {
                    xloa_doc = xxk.loa_doc;

                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (ns_doc != null)
                {
                    xns_doc = xns_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xns_doc;
                    dd3.old_file = xxk.ns_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xns_doc = xxk.ns_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null)
                {
                    xpd_doc = xpd_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xpd_doc;
                    dd3.old_file = xxk.pd_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xpd_doc = xxk.pd_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null)
                {
                    xdoa_doc = xdoa_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xdoa_doc;
                    dd3.old_file = xxk.doa_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xdoa_doc = xxk.doa_doc;
                }
            }
            catch (Exception ee)
            {

            }

            try
            {
                if (rep_pic != null)
                {
                    xrep_pic = xspec_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep_pic;
                    dd3.old_file = xxk.rep_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep_pic = xxk.rep_pic;
                }
            }
            catch (Exception ee)
            {

            }


 try
            {
                if (rep2_pic != null)
                {
                    xrep2_pic = xrep2_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep2_pic;
                    dd3.old_file = xxk.rep2_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep2_pic = xxk.rep2_pic;
                }
            }
            catch (Exception ee)
            {

            }

 try
            {
                if (rep3_pic != null)
                {
                    xrep3_pic = xrep3_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep3_pic;
                    dd3.old_file = xxk.rep3_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep3_pic = xxk.rep3_pic;
                }
            }
            catch (Exception ee)
            {

            }

 try
            {
                if (rep4_pic != null)
                {
                    xrep4_pic = xrep4_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep4_pic;
                    dd3.old_file = xxk.rep4_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep4_pic = xxk.rep4_pic;
                }
            }
            catch (Exception ee)
            {

            }
            using (connection = new SqlConnection(connectionString))
            {
                using (command = connection.CreateCommand())
                {
                    //  command.CommandTimeout = 300;
                    command.CommandText = "UPDATE pt_info SET loa_doc=@loa_doc,ns_doc=@ns_doc ,pd_doc=@pd_doc,doa_doc=@doa_doc ,rep_pic=@rep_pic ,rep2_pic=@rep2_pic ,rep3_pic=@rep3_pic ,rep4_pic=@rep4_pic  WHERE log_staff=(select id from pwallet where validationid= @log_staff)  ";

                    command.Connection.Open();
                    command.Parameters.Add("@loa_doc", SqlDbType.Text);
                    command.Parameters.Add("@ns_doc", SqlDbType.Text);
                    command.Parameters.Add("@pd_doc", SqlDbType.Text);
                    command.Parameters.Add("@doa_doc", SqlDbType.Text);
                    command.Parameters.Add("@rep_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep2_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep3_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep4_pic", SqlDbType.Text);
                    command.Parameters.Add("@log_staff", SqlDbType.NChar, 50);

                    command.Parameters["@loa_doc"].Value = xloa_doc;
                    command.Parameters["@ns_doc"].Value = xns_doc;
                    command.Parameters["@pd_doc"].Value = xpd_doc;
                    command.Parameters["@doa_doc"].Value = xdoa_doc;
                    command.Parameters["@rep_pic"].Value = xrep_pic;
                    command.Parameters["@rep2_pic"].Value = xrep2_pic;
                     command.Parameters["@rep3_pic"].Value = xrep3_pic;
                      command.Parameters["@rep4_pic"].Value = xrep4_pic;
                    command.Parameters["@log_staff"].Value = dd;
                    int h = Convert.ToInt32(command.ExecuteNonQuery());
                    command.Connection.Close();
                }
            }


            if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
        }
        catch (Exception exception)
        {
          
        }
        finally
        {

            //  xID = "0";
            // command.Connection.Close(); 
        }
        updateUploadDate(xxk.log_staff);
      //  updateUploadDate(dd);
        List<Stage> xxl = getStageByUserID(xxk.log_staff);
        String xsubject ="upload from Design  application  with number "  + xxk.reg_number;
        DateTime xxs = DateTime.Now;
        foreach (Agent_FileUpload Agent_FileUpload in ts)
        {

            Agent_FileUpload.agent_code = xxl[0].applicantID;
            Agent_FileUpload.Date_Uploaded = xxs;

            Agent_FileUpload.Status = xxl[0].data_status;
            Agent_FileUpload.pt_id = xxl[0].validationID;

            AddAgentUpload_Log(Agent_FileUpload);

        }

        AddAdminMail(xxl[0].applicantID, "upload from Design  application ", xsubject, xxk.reg_number, xxk.xID);

        return xID;
    }


 public void AddAdminMail(string agent_code, String Subject, String Message, String reg_number, String pt_id)
    {
        string str = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string str2 = DateTime.Now.ToLongTimeString();
        string connectionString = Connect();
        string str4 = "0";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Admin_Mail (Message,Subject,Date_Sent,Agent_Code,Status,pt_id,reg_number) VALUES (@Message,@Subject,@Date_Sent,@Agent_Code,@Status,@pt_id,@reg_number) SELECT SCOPE_IDENTITY()";
        connection.Open();
        command.Parameters.Add("@Message", SqlDbType.NVarChar, 500);
        command.Parameters.Add("@Subject", SqlDbType.NVarChar, 500);
        command.Parameters.Add("@Date_Sent", SqlDbType.DateTime);
        command.Parameters.Add("@Agent_Code", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@pt_id", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@Status", SqlDbType.Bit);

        command.Parameters["@Message"].Value = Message;
        command.Parameters["@Subject"].Value = Subject;
        command.Parameters["@Date_Sent"].Value = DateTime.Now;
        command.Parameters["@Agent_Code"].Value = agent_code;
        command.Parameters["@pt_id"].Value = pt_id;
        command.Parameters["@reg_number"].Value = reg_number;
        command.Parameters["@Status"].Value = 0;

        str4 = command.ExecuteScalar().ToString();
        connection.Close();

    }
    static object locker = new object();

    static string Generate15UniqueDigits()
    {
        lock (locker)
        {
            Thread.Sleep(100);
            return DateTime.Now.ToString("yyyyMMddHHmmssf");
        }
    }

    public PtInfo getPtInfoByPwalletID3(string ID)
    {
        List<PtInfo> list = new List<PtInfo>();
        PtInfo item = null;
        new PtInfo();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE reg_number='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            item = new PtInfo
            {
            xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
            };
            return item;
            // list.Add(item);
        }
        reader.Close();
        return item;
    }
public PtInfo getPtInfoByPwalletID5(string ID, string APPID)
    {

        PtInfo xd = getPtInfoByPwalletID3(ID);
        List<PtInfo> list = new List<PtInfo>();
        PtInfo item = null;
        new PtInfo();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE reg_number='" + ID + "' and log_staff=(select ID from pwallet where  applicantID ='" + APPID + "' and id= '" + xd.log_staff + "' and pwallet.data_status !='Grant Patent')  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            item = new PtInfo
            {
               xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
            };
            return item;
            // list.Add(item);
        }
        reader.Close();
        return item;
    }
 public PtInfo getPtInfoByPwalletID4(string ID, string APPID)
    {
        List<PtInfo> list = new List<PtInfo>();
        PtInfo item = null;
        new PtInfo();
        SqlConnection connection = new SqlConnection(Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE log_staff=(select top(1) ID from pwallet where validationID ='" + ID + "' and applicantID ='" + APPID + "' and pwallet.data_status !='Grant Patent')  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            item = new PtInfo
            {
               xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
            };
            return item;
            // list.Add(item);
        }
        reader.Close();
        return item;
    }
   public string UpdateTrademarkTx2(string dd, HttpPostedFile loa_doc, HttpPostedFile ns_doc, HttpPostedFile pd_doc, HttpPostedFile doa_doc, HttpPostedFile rep_pic,HttpPostedFile rep2_pic,HttpPostedFile rep3_pic,HttpPostedFile rep4_pic, string serverpath)
    {
        List<Agent_FileUpload> ts = new List<Agent_FileUpload>();
        PtInfo xxk = getPtInfoByPwalletID3(dd);
       // ptinfobackup(dd);
       updateUploadDate2(dd);

       
      //  cld.Classes.tm.MarkInfo xxk = vtm.getMarkInfoClassByUserID2(dd);

        //  Retriever ret = new Retriever();
        string xID = null; int pID = 0;
        string xloa_doc = ""; string xclaim_doc = ""; string xpct_doc = ""; string xdoa_doc = ""; string xspec_doc = "";
        string reg_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string xtime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        string xvisible = "1"; string xsync = "0";string xrep_pic="";

 string xrep2_pic="";string xrep3_pic="";string xrep4_pic="";string xpd_doc=""; string xns_doc="";

        SqlConnection connection; SqlCommand command;
        string connectionString = Connect();
        //c_pwall.reg_date = reg_date;
        //c_pwall.xtime = c_pwall.log_officer + ": " + xtime;
        //c_pwall.visible = xvisible; c_pwall.status = "1"; c_pwall.stage = "5"; c_pwall.data_status = "Fresh";
        //c_pwall.acc_p = "0"; c_pwall.rtm = "0"; 
        int app_addyID = 0;

        int rep_addyID = 0;
        int cert_infoID = 0;



        try
        {



            xID = dd;
            try
            {
                if (loa_doc != null) { xloa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", loa_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (ns_doc != null) { xns_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", ns_doc); }

            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null) { xpd_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", pd_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null) { xdoa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", doa_doc); }

            }
            catch (Exception ee)
            {

            }


            try
            {
                if (rep_pic != null) { xspec_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep_pic); }

            }
            catch (Exception ee)
            {

            }

  try
            {
                if (rep2_pic != null) { xrep2_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep2_pic); }

            }
            catch (Exception ee)
            {

            }

  try
            {
                if (rep3_pic != null) { xrep3_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep3_pic); }

            }
            catch (Exception ee)
            {

            }


  try
            {
                if (rep4_pic != null) { xrep4_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep4_pic); }

            }
            catch (Exception ee)
            {

            }

            try
            {
                if (loa_doc != null)
                {
                    xloa_doc = xloa_doc.Replace(serverpath + "admin/pt/", "");
                    Agent_FileUpload dd3 = new  Agent_FileUpload();
                    dd3.new_file = xloa_doc;
                    dd3.old_file = xxk.loa_doc;
                    ts.Add(dd3);


                }
                else
                {
                    xloa_doc = xxk.loa_doc;

                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (ns_doc != null)
                {
                    xns_doc = xns_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xns_doc;
                    dd3.old_file = xxk.ns_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xns_doc = xxk.ns_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null)
                {
                    xpd_doc = xpd_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xpd_doc;
                    dd3.old_file = xxk.pd_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xpd_doc = xxk.pd_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null)
                {
                    xdoa_doc = xdoa_doc.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xdoa_doc;
                    dd3.old_file = xxk.doa_doc;
                    ts.Add(dd3);
                }
                else
                {
                    xdoa_doc = xxk.doa_doc;
                }
            }
            catch (Exception ee)
            {

            }

            try
            {
                if (rep_pic != null)
                {
                    xrep_pic = xrep_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep_pic;
                    dd3.old_file = xxk.rep_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep_pic = xxk.rep_pic;
                }
            }
            catch (Exception ee)
            {

            }


 try
            {
                if (rep2_pic != null)
                {
                    xrep2_pic = xrep2_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep2_pic;
                    dd3.old_file = xxk.rep2_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep2_pic = xxk.rep2_pic;
                }
            }
            catch (Exception ee)
            {

            }

 try
            {
                if (rep3_pic != null)
                {
                    xrep3_pic = xrep3_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep3_pic;
                    dd3.old_file = xxk.rep3_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep3_pic = xxk.rep3_pic;
                }
            }
            catch (Exception ee)
            {

            }

 try
            {
                if (rep4_pic != null)
                {
                    xrep4_pic = xrep4_pic.Replace(serverpath + "admin/pt/", "");

                    Agent_FileUpload dd3 = new Agent_FileUpload();
                    dd3.new_file = xrep4_pic;
                    dd3.old_file = xxk.rep4_pic;
                    ts.Add(dd3);
                }
                else
                {
                    xrep4_pic = xxk.rep4_pic;
                }
            }
            catch (Exception ee)
            {

            }
            using (connection = new SqlConnection(connectionString))
            {
                using (command = connection.CreateCommand())
                {
                    //  command.CommandTimeout = 300;
                    command.CommandText = "UPDATE pt_info SET loa_doc=@loa_doc,ns_doc=@ns_doc ,pd_doc=@pd_doc,doa_doc=@doa_doc ,rep_pic=@rep_pic ,rep2_pic=@rep2_pic ,rep3_pic=@rep3_pic ,rep4_pic=@rep4_pic  WHERE reg_number= @log_staff  ";

                    command.Connection.Open();
                    command.Parameters.Add("@loa_doc", SqlDbType.Text);
                    command.Parameters.Add("@ns_doc", SqlDbType.Text);
                    command.Parameters.Add("@pd_doc", SqlDbType.Text);
                    command.Parameters.Add("@doa_doc", SqlDbType.Text);
                    command.Parameters.Add("@rep_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep2_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep3_pic", SqlDbType.Text);
                   command.Parameters.Add("@rep4_pic", SqlDbType.Text);
                    command.Parameters.Add("@log_staff", SqlDbType.NChar, 50);

                    command.Parameters["@loa_doc"].Value = xloa_doc;
                    command.Parameters["@ns_doc"].Value = xns_doc;
                    command.Parameters["@pd_doc"].Value = xpd_doc;
                    command.Parameters["@doa_doc"].Value = xdoa_doc;
                    command.Parameters["@rep_pic"].Value = xspec_doc;
                    command.Parameters["@rep2_pic"].Value = xrep2_pic;
                     command.Parameters["@rep3_pic"].Value = xrep3_pic;
                      command.Parameters["@rep4_pic"].Value = xrep4_pic;
                    command.Parameters["@log_staff"].Value = dd;
                    int h = Convert.ToInt32(command.ExecuteNonQuery());
                    command.Connection.Close();
                }
            }


            if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
        }
        catch (Exception exception)
        {
          
        }
        finally
        {

            //  xID = "0";
            // command.Connection.Close(); 
        }
        updateUploadDate(xxk.log_staff);
      //  updateUploadDate(dd);
        List<Stage> xxl = getStageByUserID(xxk.log_staff);
        String xsubject ="upload from Design   application  with number "  + xxk.reg_number;
        DateTime xxs = DateTime.Now;
        foreach (Agent_FileUpload Agent_FileUpload in ts)
        {

            Agent_FileUpload.agent_code = xxl[0].applicantID;
            Agent_FileUpload.Date_Uploaded = xxs;

            Agent_FileUpload.Status = xxl[0].data_status;
            Agent_FileUpload.pt_id = xxl[0].validationID;

            AddAgentUpload_Log(Agent_FileUpload);

        }

        AddAdminMail(xxl[0].applicantID, "upload from Design  application ", xsubject, xxk.reg_number, xxk.xID);

        return xID;
    }
  
    public void AddAgentUpload_Log(Agent_FileUpload dd)
    {
        string str = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string str2 = DateTime.Now.ToLongTimeString();
        string connectionString = Connect();
        string str4 = "0";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Agent_FileUpload (agent_code,old_file,new_file,Date_Uploaded,Status,pt_id) VALUES (@agent_code,@old_file,@new_file,@Date_Uploaded,@Status,@pt_id) SELECT SCOPE_IDENTITY()";
        connection.Open();
        command.Parameters.Add("@agent_code", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@old_file", SqlDbType.NVarChar, 500);
        command.Parameters.Add("@new_file", SqlDbType.NVarChar, 500);
        command.Parameters.Add("@Date_Uploaded", SqlDbType.DateTime);
        command.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@pt_id", SqlDbType.NVarChar, 50);


        command.Parameters["@agent_code"].Value = dd.agent_code;
        command.Parameters["@old_file"].Value =dd.old_file;
        command.Parameters["@new_file"].Value =dd.new_file;
        command.Parameters["@Date_Uploaded"].Value = dd.Date_Uploaded;
        command.Parameters["@Status"].Value = dd.Status;
        command.Parameters["@pt_id"].Value = dd.pt_id;


        foreach (SqlParameter Parameter in command.Parameters)
        {
            if (Parameter.Value == null)
            {
                Parameter.Value = DBNull.Value;
            }
        }

     

            str4 = command.ExecuteScalar().ToString();

       
        connection.Close();

    }

    public int updateUploadDate(string xid)
    {
        DateTime dd = DateTime.Now;
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = true;
        SqlCommand command = new SqlCommand("UPDATE pt_info   SET upload_date= '" +dd + "'   WHERE log_staff='" + xid + "'  ", connection);
        connection.Open();
        int num = command.ExecuteNonQuery();
        connection.Close();
        return num;
    }


    public int updateUploadDate2(string xid)
    {
        DateTime dd = DateTime.Now;
        SqlConnection connection = new SqlConnection(this.Connect());
        Boolean bb = true;
        SqlCommand command = new SqlCommand("UPDATE pt_info_backup   SET upload_date= '" + dd + "'   WHERE log_staff='" + xid + "'  ", connection);
        connection.Open();
        int num = command.ExecuteNonQuery();
        connection.Close();
        return num;
    }
	public List<pt.Assignment_info> getAssignment_infoByvalidationID(string validationID)
	{
		List<pt.Assignment_info> list = new List<pt.Assignment_info>();
		new pt.Assignment_info();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM assignment_info WHERE log_staff='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Assignment_info item = new pt.Assignment_info
			{
				ID = reader["xID"].ToString(),
				assignee_name = reader["assignee_name"].ToString(),
				assignee_address = reader["assignee_address"].ToString(),
				assignor_name = reader["assignor_name"].ToString(),
				assignor_address = reader["assignor_address"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				visible = reader["xvisible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.Priority_info> getPriority_infoByvalidationID(string validationID)
	{
		List<pt.Priority_info> list = new List<pt.Priority_info>();
		new pt.Priority_info();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM priority_info WHERE log_staff='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Priority_info item = new pt.Priority_info
			{
				xID = reader["xID"].ToString(),
				countryID = reader["countryID"].ToString(),
				app_no = reader["app_no"].ToString(),
				xdate = reader["xdate"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				xvisible = reader["xvisible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public string getClientNumber()
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		string cmdText = "SELECT TOP 1 ID,pin FROM xscard where usedstatus='0'";
		SqlCommand command = new SqlCommand(cmdText, connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["ID"].ToString() + "_" + reader["pin"].ToString();
		}
		reader.Close();
		return str;
	}
	public List<pt.Country> getCountry()
	{
		List<pt.Country> list = new List<pt.Country>();
		new pt.Country();
		SqlConnection connection = new SqlConnection(this.Connect());
		string cmdText = "SELECT * FROM country";
		SqlCommand command = new SqlCommand(cmdText, connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Country item = new pt.Country
			{
				ID = Convert.ToInt64(reader["ID"]).ToString(),
				name = reader["name"].ToString(),
				code = reader["code"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public string getCountryName(string ID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT name FROM country WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["name"].ToString();
		}
		reader.Close();
		return str;
	}
	public string getExtension(string filename)
	{
		int num = filename.LastIndexOf(".");
		return filename.Substring(num + 1);
	}
	public string getFormattedAddressByID(string ID)
	{
		string str = "";
		List<pt.Address> list = new List<pt.Address>();
		new pt.Address();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM address WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Address item = new pt.Address
			{
				ID = reader["ID"].ToString(),
				countryID = reader["countryID"].ToString(),
				stateID = reader["stateID"].ToString(),
				lgaID = reader["lgaID"].ToString(),
				city = reader["city"].ToString(),
				street = reader["street"].ToString(),
				zip = reader["zip"].ToString(),
				telephone1 = reader["telephone1"].ToString(),
				telephone2 = reader["telephone2"].ToString(),
				email1 = reader["email1"].ToString(),
				email2 = reader["email2"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		string str2 = str;
		return string.Concat(new string[]
		{
			str2,
			list[0].street.ToUpper(),
			",",
			list[0].city.ToUpper(),
			",",
			this.getStateName(list[0].stateID).ToUpper()
		});
	}
	public List<pt.NClass> getJNationalClasses()
	{
		List<pt.NClass> list = new List<pt.NClass>();
		new pt.NClass();
		SqlConnection connection = new SqlConnection(this.Connect());
		string cmdText = "SELECT xID,type,description FROM national_classes";
		SqlCommand command = new SqlCommand(cmdText, connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.NClass item = new pt.NClass
			{
				xID = Convert.ToInt64(reader["xID"]).ToString(),
				xtype = reader["type"].ToString(),
				xdescription = reader["description"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.Lga> getLga()
	{
		List<pt.Lga> list = new List<pt.Lga>();
		new pt.Lga();
		SqlConnection connection = new SqlConnection(this.Connect());
		string cmdText = "SELECT * FROM lga";
		SqlCommand command = new SqlCommand(cmdText, connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Lga item = new pt.Lga
			{
				ID = Convert.ToInt64(reader["ID"]).ToString(),
				name = reader["name"].ToString(),
				stateID = reader["stateID"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public string getLogoDescriptionName(string id)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT type from logo_description where xID='" + id + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["type"].ToString();
		}
		reader.Close();
		return str;
	}
	public string getNationalClassDesc(string id)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT description from national_classes where xID='" + id + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["description"].ToString();
		}
		return str;
	}

    public string updatePtReg2(string xID, pt.PtInfo typ)
    {
        string str2;
        string str3 = "";
        string[] st5 = typ.reg_number.Split('/');
        if (typ.xtype.ToUpper() == "NON-TEXTILE")
        {

            str2 = "NG/DS/NT/" + st5[3] + "/" + st5[4];
        }
        else
        {
            str2 = "NG/DS/T/" + st5[3] + "/" + st5[4];
        }
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "UPDATE pt_info SET reg_number=@reg_number WHERE xID=@xID ";
        connection.Open();
        command.Parameters.Add("@xID", SqlDbType.BigInt);
        command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
        command.Parameters["@xID"].Value = Convert.ToInt64(xID);
        command.Parameters["@reg_number"].Value = str2;
        str3 = command.ExecuteNonQuery().ToString();
        connection.Close();
        return str3;
    }
    public List<pt.PtInfo> getPtInfoByUserID(string xID)
	{
		List<pt.PtInfo> list = new List<pt.PtInfo>();
		new pt.PtInfo();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE xID='" + xID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.PtInfo item = new pt.PtInfo
			{
				xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}

   public void  sendemail(String vsubject, String vemail3, string vmessage)
    {
        
            int port = 0x24b;


            MailMessage mail = new MailMessage();
            mail.From =
       new MailAddress("noreply@iponigeria.com", "noreply@iponigeria.com");
            // new MailAddress("tradeservices@fsdhgroup.com");
            mail.Priority = MailPriority.High;

            mail.To.Add(
new MailAddress(vemail3));

            //    new MailAddress("ozotony@yahoo.com"));



            //mail.CC.Add(new MailAddress("Anthony.Ozoagu@firstcitygroup.com"));

            mail.Subject = vsubject;

            mail.IsBodyHtml = true;
            //String ss2 = "Dear " + px2.CompanyName + ",<br/> <br/>" + " This is to inform you that your application has been refused!! Please contact our personnel for further details .<br/> <br/>";

            ////  ss2 = ss2 + "To gain access to your account, you would need to click here <a href=\"http://88.150.164.30/IpoTest2/#/Register/" + vid + " \">click</a>   to validate your account and also make payment. " + "<br/><br/><br/>";
            //ss2 = ss2 + "Please do not reply this mail. <br/> <br/>";



            //ss2 = ss2 + "Email: info@iponigeria.com or go online to use our live feedback form <br/> <br/>";



            //ss2 = ss2 + "<b> Disclaimer: </b>This e-mail and any attachments are confidential; it must not be read, copied, disclosed or used by any person other than the above named addressees. Unauthorized use, disclosure or copying is strictly prohibited and may be unlawful. Iponigeria.com disclaims any liability for any action taken in reliance on the content of this e-mail. The comments or statements expressed in this e-mail could be personal opinions and are not necessarily  those of iponigeria.com. If you have received this email in error or think you may have done so, you may not peruse, use, disseminate, distribute or copy this message. Please notify the sender immediately and delete the original e-mail from your system.";












            //String ss = "<html> <head> </head> <body>" + ss2 + "</body> </html>";

            //  mail.Body = ss;

            mail.Body = vmessage;

            SmtpClient client = new SmtpClient("88.150.164.30");
            //  SmtpClient client = new SmtpClient("192.168.0.12");

            client.Port = port;

            //    client.Credentials = new System.Net.NetworkCredential("paymentsupport@einaosolutions.com", "Zues.4102.Hector");

            client.Credentials = new System.Net.NetworkCredential("noreply@iponigeria.com", "Einao2015@@$");



            //   new System.Net.NetworkCredential("ebusiness@firstcitygroup.com", "welcome@123");
            //   new System.Net.NetworkCredential(q60.smtp_user, q60.smtp_password);







            client.Send(mail);




    }
    public List<pt.PtInfo> getPtInfoByPwalletID(string ID)
	{
		List<pt.PtInfo> list = new List<pt.PtInfo>();
		new pt.PtInfo();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE log_staff='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.PtInfo item = new pt.PtInfo
			{
				xID = reader["xID"].ToString(),
				reg_number = reader["reg_number"].ToString(),
				xtype = reader["xtype"].ToString(),
				title_of_invention = reader["title_of_invention"].ToString(),
				pt_class = reader["pt_class"].ToString(),
				loa_doc = reader["loa_doc"].ToString(),
				doa_doc = reader["doa_doc"].ToString(),
				ns_doc = reader["ns_doc"].ToString(),
				pd_doc = reader["pd_doc"].ToString(),
				rep_pic = reader["rep_pic"].ToString(),
				rep2_pic = reader["rep2_pic"].ToString(),
				rep3_pic = reader["rep3_pic"].ToString(),
				rep4_pic = reader["rep4_pic"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				reg_date = reader["reg_date"].ToString(),
				xvisible = reader["xvisible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}

    public List<pt.PtInfo> getPtInfoBy()
    {
        List<pt.PtInfo> list = new List<pt.PtInfo>();
        new pt.PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info  ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            pt.PtInfo item = new pt.PtInfo
            {
                xID = reader["xID"].ToString(),
                reg_number = reader["reg_number"].ToString(),
                xtype = reader["xtype"].ToString(),
                title_of_invention = reader["title_of_invention"].ToString(),
                pt_class = reader["pt_class"].ToString(),
                loa_doc = reader["loa_doc"].ToString(),
                doa_doc = reader["doa_doc"].ToString(),
                ns_doc = reader["ns_doc"].ToString(),
                pd_doc = reader["pd_doc"].ToString(),
                rep_pic = reader["rep_pic"].ToString(),
                rep2_pic = reader["rep2_pic"].ToString(),
                rep3_pic = reader["rep3_pic"].ToString(),
                rep4_pic = reader["rep4_pic"].ToString(),
                log_staff = reader["log_staff"].ToString(),
                reg_date = reader["reg_date"].ToString(),
                xvisible = reader["xvisible"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;
    }
	public string getPtTypeName(string id)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT type from pt_type where xID='" + id + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["type"].ToString();
		}
		reader.Close();
		return str;
	}
	public List<pt.Stage> getPwalletDetailsByID(string ID)
	{
		List<pt.Stage> list = new List<pt.Stage>();
		new pt.Stage();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM pwallet WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Stage item = new pt.Stage
			{
				ID = reader["ID"].ToString(),
				applicantID = reader["applicantID"].ToString(),
				validationID = reader["validationID"].ToString(),
				stage = reader["stage"].ToString(),
				amt = reader["amt"].ToString(),
				reg_date = reader["reg_date"].ToString(),
                data_status= reader["data_status"].ToString()
            };
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public string getPwalletID(string validationID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT ID FROM pwallet WHERE validationID='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = Convert.ToInt64(reader["ID"]).ToString();
		}
		reader.Close();
		return str;
	}
	public string getPwalletIDByMID(string pt_infoID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT log_staff from pt_info where xID='" + pt_infoID + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["log_staff"].ToString();
		}
		reader.Close();
		return str;
	}
	public pt.Representative getRepByUserID(string ID)
	{
		pt.Representative representative = new pt.Representative();
		representative.ID = "";
		representative.agent_code = "";
		representative.xname = "";
		representative.nationality = "";
		representative.country = "";
		representative.state = "";
		representative.address = "";
		representative.xemail = "";
		representative.xmobile = "";
		representative.log_staff = "";
		representative.visible = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM representative WHERE log_staff='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			representative.ID = reader["ID"].ToString();
			representative.agent_code = reader["agent_code"].ToString();
			representative.xname = reader["xname"].ToString();
			representative.nationality = reader["nationality"].ToString();
			representative.country = reader["country"].ToString();
			representative.nationality = reader["nationality"].ToString();
			representative.state = reader["state"].ToString();
			representative.address = reader["address"].ToString();
			representative.xemail = reader["xemail"].ToString();
			representative.xmobile = reader["xmobile"].ToString();
			representative.log_staff = reader["log_staff"].ToString();
			representative.visible = reader["visible"].ToString();
		}
		reader.Close();
		return representative;
	}
	public List<pt.Representative> getRepListByUserID(string validationID)
	{
		List<pt.Representative> list = new List<pt.Representative>();
		new pt.Representative();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM representative WHERE log_staff='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Representative item = new pt.Representative
			{
				ID = reader["ID"].ToString(),
				agent_code = reader["agent_code"].ToString(),
				xname = reader["xname"].ToString(),
				nationality = reader["nationality"].ToString(),
				country = reader["country"].ToString(),
				state = reader["state"].ToString(),
				address = reader["address"].ToString(),
				xemail = reader["xemail"].ToString(),
				xmobile = reader["xmobile"].ToString(),
				log_staff = reader["log_staff"].ToString(),
				visible = reader["visible"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.Stage> getStageByUserID(string ID)
	{
		List<pt.Stage> list = new List<pt.Stage>();
		new pt.Stage();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM pwallet WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Stage item = new pt.Stage
			{
				ID = reader["ID"].ToString(),
				applicantID = reader["applicantID"].ToString(),
				validationID = reader["validationID"].ToString(),
				stage = reader["stage"].ToString(),
				status = reader["status"].ToString(),
				amt = reader["amt"].ToString(),
				reg_date = reader["reg_date"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public int getStageIDByvalidationID(string validationID)
	{
		int ID = 0;
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT ID FROM pwallet WHERE validationID='" + validationID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			ID = Convert.ToInt32(reader["ID"]);
		}
		reader.Close();
		return ID;
	}
	public List<pt.Stage> getStageByUserIDAcc(string validationID, string agentID)
	{
		List<pt.Stage> list = new List<pt.Stage>();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand(string.Concat(new string[]
		{
			"SELECT * FROM pwallet WHERE validationID='",
			validationID,
			"'  AND applicantID='",
			agentID,
			"' AND stage='5' AND data_status <>'' "
		}), connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.Stage item = new pt.Stage
			{
				ID = reader["ID"].ToString(),
				applicantID = reader["applicantID"].ToString(),
				validationID = reader["validationID"].ToString(),
				stage = reader["stage"].ToString(),
				status = reader["status"].ToString(),
				data_status = reader["data_status"].ToString(),
				amt = reader["amt"].ToString(),
				reg_date = reader["reg_date"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public List<pt.State> getState(string countryID)
	{
		List<pt.State> list = new List<pt.State>();
		new pt.State();
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT * FROM state WHERE countryID='" + countryID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			pt.State item = new pt.State
			{
				ID = Convert.ToInt64(reader["ID"]).ToString(),
				name = reader["name"].ToString(),
				countryID = reader["countryID"].ToString()
			};
			list.Add(item);
		}
		reader.Close();
		return list;
	}
	public string getStateName(string ID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT name FROM state WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["name"].ToString();
		}
		reader.Close();
		return str;
	}
	public string ValidationIDByPwalletID(string ID)
	{
		string str = "";
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("SELECT validationID FROM pwallet WHERE ID='" + ID + "' ", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			str = reader["validationID"].ToString();
		}
		reader.Close();
		return str;
	}

  
    //public string addNewDesign(List<pt.Applicant> lt_app, List<pt.Priority_info> lt_pri, List<pt.Inventor> lt_inv, pt.PtInfo c_pt, pt.Assignment_info c_assinfo, pt.Representative c_rep)
    //{
    //    foreach (pt.Applicant c_app in lt_app)
    //    {
    //        this.addApplicant(c_app);
    //    }
    //    foreach (pt.Priority_info c_pri in lt_pri)
    //    {
    //        this.addPriority_info(c_pri);
    //    }
    //    foreach (pt.Inventor c_inv in lt_inv)
    //    {
    //        this.addInventor(c_inv);
    //    }
    //    this.addAssignment_info(c_assinfo);
    //   string xID = this.addPt(c_pt);
    //    this.updatePtReg(xID, c_pt.xtype);
    //    this.addRepresentative(c_rep);
    //    this.updatePwalletStatus(c_pt.log_staff, "0");
    //    return xID;
    //}

    public string addNewDesign(List<Applicant> lt_app, List<pt.Priority_info> lt_pri, List<pt.Inventor> lt_inv, PtInfo c_pt, pt.Assignment_info c_assinfo, Representative c_rep, string serverpath, string transID, string agent, string amt, string log_staffID)
    {
        string xID = "";


  

                SqlConnection connection;
        SqlCommand command;
        string commandText;
        object obj2;
        string connectionString = Connect();
        string str3 = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string str4 = "1";
        string str5 = "1";
        string str6 = "1";
        string str7 = "Fresh";
        string pwalletID = "";
        //  string str2 = ConnectXpay();
        int num = 0;

        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO pwallet (validationID,applicantID,log_officer,amt,stage,status,data_status,reg_date,visible ) ";
                command.CommandTimeout = 300;
                commandText = command.CommandText;
                command.CommandText = commandText + " VALUES ('" + transID + "','" + agent + "','0','" + amt + "','" + str6 + "','" + str5 + "','" + str7 + "','" + str3 + "','" + str4 + "' ) ";
                command.CommandText = command.CommandText + " SELECT SCOPE_IDENTITY()";
                command.Connection.Open();

                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }
                num = Convert.ToInt32(command.ExecuteScalar());
            }
        }
        foreach (Applicant c_app in lt_app)
        {
            if ((c_app.xname != null) && (c_app.xname != ""))
            {
                using (connection = new SqlConnection(connectionString))
                {
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO applicant (xname,address,xemail,xmobile,log_staff,visible) VALUES (@xname,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
                        connection.Open();
                        command.Parameters.Add("@xname", SqlDbType.VarChar);
                        command.Parameters.Add("@address", SqlDbType.Text);
                        command.Parameters.Add("@xemail", SqlDbType.VarChar);
                        command.Parameters.Add("@xmobile", SqlDbType.VarChar);
                        command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
                        command.Parameters.Add("@visible", SqlDbType.VarChar, 10);

                        command.Parameters["@xname"].Value = c_app.xname;
                        command.Parameters["@address"].Value = c_app.address;
                        command.Parameters["@xemail"].Value = c_app.xemail;
                        command.Parameters["@xmobile"].Value = c_app.xmobile;
                        command.Parameters["@log_staff"].Value = num;// c_app.log_staff;
                        command.Parameters["@visible"].Value = c_app.visible;


                        foreach (SqlParameter Parameter in command.Parameters)
                        {
                            if (Parameter.Value == null)
                            {
                                Parameter.Value = DBNull.Value;
                            }
                        }
                        string succ = command.ExecuteScalar().ToString();
                        //  connection.Close();
                        //  return succ;

                    }

                }
            }
        }
        //   string pwalletID = addPwallet(serverpath, transID, agent, amt, log_staffID);

        //foreach (Applicant c_app in lt_app)
        //{
        //    this.addApplicant(c_app, pwalletID);
        //}


        foreach (Priority_info c_pri in lt_pri)
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO priority_info (countryID,app_no,xdate,log_staff,xvisible) VALUES (@countryID,@app_no,@xdate,@log_staff,@xvisible) SELECT SCOPE_IDENTITY()";
                    connection.Open();
                    command.Parameters.Add("@countryID", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@app_no", SqlDbType.VarChar);
                    command.Parameters.Add("@xdate", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
                    command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);

                    command.Parameters["@countryID"].Value = c_pri.countryID;
                    command.Parameters["@app_no"].Value = c_pri.app_no;
                    command.Parameters["@xdate"].Value = c_pri.xdate;
                    command.Parameters["@log_staff"].Value = num;// c_pri.log_staff;
                    command.Parameters["@xvisible"].Value = c_pri.xvisible;


                    foreach (SqlParameter Parameter in command.Parameters)
                    {
                        if (Parameter.Value == null)
                        {
                            Parameter.Value = DBNull.Value;
                        }
                    }
                    string succ = command.ExecuteScalar().ToString();
                    //  connection.Close();
                    //    return succ;
                }
            }

        }

        //foreach (Priority_info c_pri in lt_pri)
        //{
        //    this.addPriority_info(c_pri, pwalletID);
        //}
        foreach (Inventor c_inv in lt_inv)
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO inventor (xname,address,xemail,xmobile,log_staff,visible) VALUES (@xname,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
                    connection.Open();
                    command.Parameters.Add("@xname", SqlDbType.VarChar);
                    command.Parameters.Add("@address", SqlDbType.Text);
                    command.Parameters.Add("@xemail", SqlDbType.VarChar);
                    command.Parameters.Add("@xmobile", SqlDbType.VarChar);
                    command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
                    command.Parameters.Add("@visible", SqlDbType.VarChar, 10);

                    command.Parameters["@xname"].Value = c_inv.xname;
                    command.Parameters["@address"].Value = c_inv.address;
                    command.Parameters["@xemail"].Value = c_inv.xemail;
                    command.Parameters["@xmobile"].Value = c_inv.xmobile;
                    command.Parameters["@log_staff"].Value = num;// c_inv.log_staff;
                    command.Parameters["@visible"].Value = c_inv.visible;


                    foreach (SqlParameter Parameter in command.Parameters)
                    {
                        if (Parameter.Value == null)
                        {
                            Parameter.Value = DBNull.Value;
                        }
                    }
                    string succ = command.ExecuteScalar().ToString();
                    ///     connection.Close();
                    //  return succ;

                }
            }

        }

        //foreach (Inventor c_inv in lt_inv)
        //{
        //    this.addInventor(c_inv, pwalletID);
        //}

        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {

                command.CommandText = "INSERT INTO assignment_info (assignee_name,assignee_address,assignor_name,assignor_address,log_staff,xvisible) VALUES (@assignee_name,@assignee_address,@assignor_name,@assignor_address,@log_staff,@xvisible) SELECT SCOPE_IDENTITY()";
                connection.Open();
                command.Parameters.Add("@assignee_name", SqlDbType.VarChar);
                command.Parameters.Add("@assignee_address", SqlDbType.Text);
                command.Parameters.Add("@assignor_name", SqlDbType.VarChar);
                command.Parameters.Add("@assignor_address", SqlDbType.Text);
                command.Parameters.Add("@log_staff", SqlDbType.VarChar, 50);
                command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);

                command.Parameters["@assignee_name"].Value = c_assinfo.assignee_name;
                command.Parameters["@assignee_address"].Value = c_assinfo.assignee_address;
                command.Parameters["@assignor_name"].Value = c_assinfo.assignor_name;
                command.Parameters["@assignor_address"].Value = c_assinfo.assignor_address;
                command.Parameters["@log_staff"].Value = num;// c_ass.log_staff;
                command.Parameters["@xvisible"].Value = c_assinfo.visible;


                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }
                string succ = command.ExecuteScalar().ToString();
                //connection.Close();
                //  return succ;

            }
        }

        //  this.addAssignment_info(c_assinfo, pwalletID);

        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {
                // SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO pt_Info (reg_number,xtype,title_of_invention,pt_class,loa_doc,doa_doc,ns_doc,pd_doc,rep_pic,rep2_pic,rep3_pic,rep4_pic,log_staff,reg_date,xvisible) VALUES (@reg_number,@xtype,@title_of_invention,@pt_class,@loa_doc,@doa_doc,@ns_doc,@pd_doc,@rep_pic,@rep2_pic,@rep3_pic,@rep4_pic,@log_staff,@reg_date,@xvisible) SELECT SCOPE_IDENTITY()";
                connection.Open();
                command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@xtype", SqlDbType.NVarChar);
                command.Parameters.Add("@title_of_invention", SqlDbType.NVarChar);
                command.Parameters.Add("@pt_class", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@loa_doc", SqlDbType.Text);
                command.Parameters.Add("@doa_doc", SqlDbType.Text);
                command.Parameters.Add("@ns_doc", SqlDbType.Text);
                command.Parameters.Add("@pd_doc", SqlDbType.Text);
                command.Parameters.Add("@rep_pic", SqlDbType.Text);
                command.Parameters.Add("@rep2_pic", SqlDbType.Text);
                command.Parameters.Add("@rep3_pic", SqlDbType.Text);
                command.Parameters.Add("@rep4_pic", SqlDbType.Text);
                command.Parameters.Add("@log_staff", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@reg_date", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@xvisible", SqlDbType.NVarChar, 10);
                command.Parameters["@reg_number"].Value = c_pt.reg_number;
                command.Parameters["@xtype"].Value = c_pt.xtype;
                command.Parameters["@title_of_invention"].Value = c_pt.title_of_invention;
                command.Parameters["@pt_class"].Value = c_pt.pt_class;
                command.Parameters["@loa_doc"].Value = "";
                command.Parameters["@doa_doc"].Value = "";
                command.Parameters["@ns_doc"].Value = "";
                command.Parameters["@pd_doc"].Value = "";
                command.Parameters["@rep_pic"].Value = "";
                command.Parameters["@rep2_pic"].Value = "";
                command.Parameters["@rep3_pic"].Value = "";
                command.Parameters["@rep4_pic"].Value = "";
                command.Parameters["@log_staff"].Value = num;// c_pt.log_staff;
                command.Parameters["@reg_date"].Value = c_pt.reg_date;
                command.Parameters["@xvisible"].Value = c_pt.xvisible;
                //   string succ = command.ExecuteScalar().ToString();


                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }

                xID = command.ExecuteScalar().ToString();
                //   connection.Close();
                //  return succ;
            }

        }
        //  xID = this.addPt(c_pt, pwalletID);
        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {
                string str = "0";
                string str2 = "";
                if (c_pt.xtype.ToUpper() == "NON-TEXTILE")
                {
                    str2 = "NG/DS/NT/" + DateTime.Today.Date.ToString("yyyy") + "/" + xID;
                }
                else
                {
                    str2 = "NG/DS/T/" + DateTime.Today.Date.ToString("yyyy") + "/" + xID;
                }

                command.CommandText = "UPDATE pt_info SET reg_number=@reg_number WHERE xID=@xID ";
                connection.Open();
                command.Parameters.Add("@xID", SqlDbType.BigInt);
                command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
                command.Parameters["@xID"].Value = Convert.ToInt64(xID);
                command.Parameters["@reg_number"].Value = str2;

                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }
                str = command.ExecuteNonQuery().ToString();


            }
        }
        //   this.updatePtReg(xID, c_pt.xtype);

        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO representative (agent_code,xname,nationality,country,state,address,xemail,xmobile,log_staff,visible) VALUES (@agent_code,@xname,@nationality,@country,@state,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
                connection.Open();
                command.Parameters.Add("@agent_code", SqlDbType.VarChar);
                command.Parameters.Add("@xname", SqlDbType.NVarChar);
                command.Parameters.Add("@nationality", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@country", SqlDbType.VarChar, 50);
                command.Parameters.Add("@state", SqlDbType.VarChar, 50);
                command.Parameters.Add("@address", SqlDbType.Text);
                command.Parameters.Add("@xemail", SqlDbType.NVarChar);
                command.Parameters.Add("@xmobile", SqlDbType.VarChar);
                command.Parameters.Add("@log_staff", SqlDbType.VarChar, 50);
                command.Parameters.Add("@visible", SqlDbType.VarChar, 10);

                command.Parameters["@agent_code"].Value = c_rep.agent_code;
                command.Parameters["@xname"].Value = c_rep.xname;
                command.Parameters["@nationality"].Value = c_rep.nationality;
                command.Parameters["@country"].Value = c_rep.country;
                command.Parameters["@state"].Value = c_rep.state;
                command.Parameters["@address"].Value = c_rep.address;
                command.Parameters["@xemail"].Value = c_rep.xemail;
                command.Parameters["@xmobile"].Value = c_rep.xmobile;
                command.Parameters["@log_staff"].Value = num;// c_rep.log_staff;
                command.Parameters["@visible"].Value = c_rep.visible;


                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }
                string succ = command.ExecuteScalar().ToString();

            }
        }
        //  this.addRepresentative(c_rep, pwalletID);

        using (connection = new SqlConnection(connectionString))
        {
            using (command = connection.CreateCommand())
            {

                command.CommandText = "UPDATE pwallet SET stage=5,log_officer=@log_officer WHERE ID=@ID ";
                connection.Open();
                command.Parameters.Add("@ID", SqlDbType.BigInt);
                command.Parameters.Add("@log_officer", SqlDbType.NVarChar, 50);
                command.Parameters["@ID"].Value = Convert.ToInt64(num);
                command.Parameters["@log_officer"].Value = "0";

                foreach (SqlParameter Parameter in command.Parameters)
                {
                    if (Parameter.Value == null)
                    {
                        Parameter.Value = DBNull.Value;
                    }
                }
                string str2 = command.ExecuteNonQuery().ToString();

            }
        }
        //   this.updatePwalletStatus(pwalletID, "0");
        return xID;
    }
    public string updatePwalletStatus(string pwalletID, string log_officer)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "UPDATE pwallet SET stage=5,log_officer=@log_officer WHERE ID=@ID ";
		connection.Open();
		command.Parameters.Add("@ID", SqlDbType.BigInt);
		command.Parameters.Add("@log_officer", SqlDbType.NVarChar, 50);
		command.Parameters["@ID"].Value = Convert.ToInt64(pwalletID);
		command.Parameters["@log_officer"].Value = log_officer;


        foreach (SqlParameter Parameter in command.Parameters)
        {
            if (Parameter.Value == null)
            {
                Parameter.Value = DBNull.Value;
            }
        }
        string str2 = command.ExecuteNonQuery().ToString();
		connection.Close();
		return str2;
	}
	public string updatePtDocz(string doa_doc, string loa_doc, string ns_doc, string pd_doc, string rep_pic, string rep2_pic, string rep3_pic, string rep4_pic, string pwalletID)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "UPDATE pt_info SET doa_doc=@doa_doc,loa_doc=@loa_doc,ns_doc=@ns_doc,pd_doc=@pd_doc,rep_pic=@rep_pic,rep2_pic=@rep2_pic,rep3_pic=@rep3_pic,rep4_pic=@rep4_pic WHERE xID=@pwalletID ";
		connection.Open();
		command.Parameters.Add("@loa_doc", SqlDbType.Text);
		command.Parameters.Add("@doa_doc", SqlDbType.Text);
		command.Parameters.Add("@ns_doc", SqlDbType.Text);
		command.Parameters.Add("@pd_doc", SqlDbType.Text);
		command.Parameters.Add("@rep_pic", SqlDbType.Text);
		command.Parameters.Add("@rep2_pic", SqlDbType.Text);
		command.Parameters.Add("@rep3_pic", SqlDbType.Text);
		command.Parameters.Add("@rep4_pic", SqlDbType.Text);
		command.Parameters.Add("@pwalletID", SqlDbType.NVarChar);
		command.Parameters["@loa_doc"].Value = loa_doc;
		command.Parameters["@doa_doc"].Value = doa_doc;
		command.Parameters["@ns_doc"].Value = ns_doc;
		command.Parameters["@pd_doc"].Value = pd_doc;
		command.Parameters["@rep_pic"].Value = rep_pic;
		command.Parameters["@rep2_pic"].Value = rep2_pic;
		command.Parameters["@rep3_pic"].Value = rep3_pic;
		command.Parameters["@rep4_pic"].Value = rep4_pic;
		command.Parameters["@pwalletID"].Value = pwalletID;


        foreach (SqlParameter Parameter in command.Parameters)
        {
            if (Parameter.Value == null)
            {
                Parameter.Value = DBNull.Value;
            }
        }
        string succ = command.ExecuteNonQuery().ToString();
		connection.Close();
		return succ;
	}

   
    
    public string updatePtReg(string xID, string typ)
	{
		string str2;
		if (typ.ToUpper() == "NON-TEXTILE")
		{
			str2 = "NG/DS/NT/" + DateTime.Today.Date.ToString("yyyy") + "/" + xID;
		}
		else
		{
			str2 = "NG/DS/T/" + DateTime.Today.Date.ToString("yyyy") + "/" + xID;
		}
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "UPDATE pt_info SET reg_number=@reg_number WHERE xID=@xID ";
		connection.Open();
		command.Parameters.Add("@xID", SqlDbType.BigInt);
		command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
		command.Parameters["@xID"].Value = Convert.ToInt64(xID);
		command.Parameters["@reg_number"].Value = str2;
		string str3 = command.ExecuteNonQuery().ToString();
		connection.Close();
		return str3;
	}

    public String Vconvert(long dd)
    {
        return Convert.ToString(dd);

    }

    public string UpdateTrademarkTx(string dd, HttpPostedFile loa_doc, HttpPostedFile doa_doc, HttpPostedFile pd_doc, HttpPostedFile rep1_pic, HttpPostedFile rep2_pic, HttpPostedFile rep3_pic, HttpPostedFile rep4_pic, string serverpath)
    {

        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();
        Int64 tr = Convert.ToInt64(dd);
        var cc = (from t1 in _db.pt_info
                
                  where t1.xID==tr
                  select t1).FirstOrDefault();

        //  cld.Classes.tm.MarkInfo xxk = vtm.getMarkInfoClassByUserID2(dd);

        //  Retriever ret = new Retriever();
        string xID = null; int pID = 0;
        if (cc != null) {
            xID = cc.log_staff;
        }
        string xloa_doc = ""; string xpd_doc = ""; string xrep1_pic = ""; string xdoa_doc = ""; string xrep2_pic = ""; string xrep3_pic = ""; string xrep4_pic = "";
        string reg_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string xtime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        string xvisible = "1"; string xsync = "0";

        SqlConnection connection; SqlCommand command;
        string connectionString = Connect();
      
        int app_addyID = 0;

        int rep_addyID = 0;
        int cert_infoID = 0;



        try
        {



            xID = dd;
            try
            {
                if (loa_doc != null) { xloa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", loa_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null) { xdoa_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", doa_doc); }

            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null) { xpd_doc = doUploadDoc2(xID, serverpath + "admin/pt/docz/", pd_doc); }
            }

            catch (Exception ee)
            {

            }
            try
            {
                if (rep1_pic != null) { xrep1_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep1_pic); }

            }
            catch (Exception ee)
            {

            }


            try
            {
                if (rep2_pic != null) { xrep2_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep2_pic); }

            }
            catch (Exception ee)
            {

            }

            try
            {
                if (rep3_pic != null) { xrep3_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep3_pic); }

            }
            catch (Exception ee)
            {

            }

            try
            {
                if (rep4_pic != null) { xrep4_pic = doUploadDoc2(xID, serverpath + "admin/pt/docz/", rep4_pic); }

            }
            catch (Exception ee)
            {

            }
            try
            {
                if (loa_doc != null)
                {
                    xloa_doc = xloa_doc.Replace(serverpath + "admin/pt/", "");
                    


                }
                else
                {
                    xloa_doc = cc.loa_doc;

                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (doa_doc != null)
                {
                    xdoa_doc = xdoa_doc.Replace(serverpath + "admin/pt/", "");
                                      
                }
                else
                {
                    xdoa_doc = cc.doa_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (pd_doc != null)
                {
                    xpd_doc = xpd_doc.Replace(serverpath + "admin/pt/", "");

                                   }
                else
                {
                    xpd_doc = cc.pd_doc;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (rep1_pic != null)
                {
                    xrep1_pic = xrep1_pic.Replace(serverpath + "admin/pt/", "");
                }
                else
                {
                    xrep1_pic = cc.rep_pic;
                }
            }
            catch (Exception ee)
            {

            }

            try
            {
                if (rep2_pic != null)
                {
                    xrep2_pic = xrep2_pic.Replace(serverpath + "admin/pt/", "");

                  
                }
                else
                {
                    xrep2_pic = cc.rep2_pic;
                }
            }
            catch (Exception ee)
            {

            }


            try
            {
                if (rep3_pic != null)
                {
                    xrep3_pic = xrep3_pic.Replace(serverpath + "admin/pt/", "");


                }
                else
                {
                    xrep3_pic = cc.rep3_pic;
                }
            }
            catch (Exception ee)
            {

            }
            try
            {
                if (rep4_pic != null)
                {
                    xrep4_pic = xrep4_pic.Replace(serverpath + "admin/pt/", "");


                }
                else
                {
                    xrep4_pic = cc.rep4_pic;
                }
            }
            catch (Exception ee)
            {

            }

           


          
        }
        catch (Exception exception)
        {

        }
        finally
        {

            //  xID = "0";
            // command.Connection.Close(); 
        }

        cc.loa_doc = xloa_doc;
        cc.doa_doc = xdoa_doc;
        cc.pd_doc = xpd_doc;
        cc.rep_pic = xrep1_pic;
        cc.rep2_pic = xrep2_pic;
        cc.rep3_pic = xrep3_pic;
        cc.rep4_pic = xrep4_pic;
        _db.SaveChanges();
        return xID;
    }
    public void UpdateApplicant(Vapplicant dd)
    {
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();
        long ds = Convert.ToInt64(dd.ID);
        var cc = (from t1 in _db.applicants
                
                  where t1.ID ==ds
                  select t1).FirstOrDefault();

        string sp = "";

        cc.xname = dd.xname;
        cc.xmobile = dd.xmobile;
        cc.xemail = dd.xemail;
        cc.address = dd.address;

        _db.SaveChanges();


    }


    public void UpdateInventor(Vinventor dd)
    {
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();
        long ds = Convert.ToInt64(dd.ID);
        var cc = (from t1 in _db.inventors

                  where t1.ID == ds
                  select t1).FirstOrDefault();
        cc.xname = dd.xname;
        cc.xmobile = dd.xmobile;
        cc.xemail = dd.xemail;
        cc.address = dd.address;

        _db.SaveChanges();

        string sp = "";


    }


    public void UpdatePtInfo(VptInfo dd)
    {
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();
        long ds = Convert.ToInt64(dd.xID);
        var cc = (from t1 in _db.pt_info

                  where t1.xID == ds
                  select t1).FirstOrDefault();
        cc.reg_number = dd.reg_number;
        cc.xtype = dd.xtype;
        cc.title_of_invention = dd.title_of_invention;
        cc.reg_date = dd.reg_date;

        _db.SaveChanges();

        string sp = "";


    }
    public List<applicant> getApplicant(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                       join t2 in _db.applicants
                       on SqlFunctions.StringConvert((double)t1.ID).Trim()
                       equals t2.log_staff.Trim()
                       where t1.validationID == validationid
                       select t2).ToList();

   

        return cc;

    }


    public List<pwallet> getpwallet(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                  
                  where t1.validationID == validationid
                  select t1).ToList();



        return cc;

    }


    public List<inventor> getInventors(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                  join t2 in _db.inventors
                  on SqlFunctions.StringConvert((double)t1.ID).Trim()
                  equals t2.log_staff.Trim()
                  where t1.validationID == validationid
                  select t2).ToList();



        return cc;

    }

    public List<priority_info> getPriority(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                  join t2 in _db.priority_info
                  on SqlFunctions.StringConvert((double)t1.ID).Trim()
                  equals t2.log_staff.Trim()
                  where t1.validationID == validationid
                  select t2).ToList();



        return cc;

    }

    public List<country> getCountry2()
    {
        
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.countries
                
                  select t1).ToList();



        return cc;

    }

    public List<assignment_info> getAssignment(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                  join t2 in _db.assignment_info
                  on SqlFunctions.StringConvert((double)t1.ID).Trim()
                  equals t2.log_staff.Trim()
                  where t1.validationID == validationid
                  select t2).ToList();



        return cc;

    }

    public List<pt_info> getPtInfo(string validationid)
    {
        List<Applicant> dd = new List<Applicant>();
        ba2xai_cldds_backupEntities _db = new ba2xai_cldds_backupEntities();

        var cc = (from t1 in _db.pwallets
                  join t2 in _db.pt_info
                  on SqlFunctions.StringConvert((double)t1.ID).Trim()
                  equals t2.log_staff.Trim()
                  where t1.validationID == validationid
                  select t2).ToList();



        return cc;

    }

    public string addAddress(pt.Address c_app_addy, string pwalletID)
	{
		string str = DateTime.Today.Date.ToString("yyyy-MM-dd");
		string str2 = "1";
		if (c_app_addy.countryID == null)
		{
			c_app_addy.countryID = "";
		}
		if (c_app_addy.stateID == null)
		{
			c_app_addy.stateID = "";
		}
		if (c_app_addy.city == null)
		{
			c_app_addy.city = "";
		}
		if (c_app_addy.street == null)
		{
			c_app_addy.street = "";
		}
		if (c_app_addy.telephone1 == null)
		{
			c_app_addy.telephone1 = "";
		}
		if (c_app_addy.email1 == null)
		{
			c_app_addy.email1 = "";
		}
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO address (countryID,stateID,city,street,telephone1,email1,log_staff,reg_date,visible) VALUES (@countryID,@stateID,@city,@street,@telephone1,@email1,@log_staff,@reg_date,@visible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@countryID", SqlDbType.VarChar, 10);
		command.Parameters.Add("@stateID", SqlDbType.NVarChar, 10);
		command.Parameters.Add("@city", SqlDbType.VarChar, 40);
		command.Parameters.Add("@street", SqlDbType.Text);
		command.Parameters.Add("@telephone1", SqlDbType.NVarChar, 40);
		command.Parameters.Add("@email1", SqlDbType.VarChar, 40);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 40);
		command.Parameters.Add("@reg_date", SqlDbType.VarChar, 40);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 1);
		command.Parameters["@countryID"].Value = c_app_addy.countryID;
		command.Parameters["@stateID"].Value = c_app_addy.stateID;
		command.Parameters["@city"].Value = c_app_addy.city;
		command.Parameters["@street"].Value = c_app_addy.street;
		command.Parameters["@telephone1"].Value = c_app_addy.telephone1;
		command.Parameters["@email1"].Value = c_app_addy.email1;
		command.Parameters["@log_staff"].Value = pwalletID;
		command.Parameters["@reg_date"].Value = str;
		command.Parameters["@visible"].Value = str2;
		string str3 = command.ExecuteScalar().ToString();
		connection.Close();
		return str3;
	}
	public string addAos(pt.AddressService c_aos, string pwalletID)
	{
		string str = DateTime.Today.Date.ToString("yyyy-MM-dd");
		string str2 = "1";
		if (c_aos.countryID == null)
		{
			c_aos.countryID = "";
		}
		if (c_aos.stateID == null)
		{
			c_aos.stateID = "";
		}
		if (c_aos.city == null)
		{
			c_aos.city = "";
		}
		if (c_aos.street == null)
		{
			c_aos.street = "";
		}
		if (c_aos.telephone1 == null)
		{
			c_aos.telephone1 = "";
		}
		if (c_aos.email1 == null)
		{
			c_aos.email1 = "";
		}
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO address_service (countryID,stateID,city,street,telephone1,email1,log_staff,reg_date,visible) VALUES (@countryID,@stateID,@city,@street,@telephone1,@email1,@log_staff,@reg_date,@visible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@countryID", SqlDbType.VarChar, 10);
		command.Parameters.Add("@stateID", SqlDbType.NVarChar, 10);
		command.Parameters.Add("@city", SqlDbType.VarChar, 40);
		command.Parameters.Add("@street", SqlDbType.Text);
		command.Parameters.Add("@telephone1", SqlDbType.NVarChar, 40);
		command.Parameters.Add("@email1", SqlDbType.VarChar, 40);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 40);
		command.Parameters.Add("@reg_date", SqlDbType.VarChar, 40);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 1);
		command.Parameters["@countryID"].Value = c_aos.countryID;
		command.Parameters["@stateID"].Value = c_aos.stateID;
		command.Parameters["@city"].Value = c_aos.city;
		command.Parameters["@street"].Value = c_aos.street;
		command.Parameters["@telephone1"].Value = c_aos.telephone1;
		command.Parameters["@email1"].Value = c_aos.email1;
		command.Parameters["@log_staff"].Value = pwalletID;
		command.Parameters["@reg_date"].Value = str;
		command.Parameters["@visible"].Value = str2;
		string str3 = command.ExecuteScalar().ToString();
		connection.Close();
		return str3;
	}
	public string addApplicant(pt.Applicant c_app)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO applicant (xname,address,xemail,xmobile,log_staff,visible) VALUES (@xname,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@xname", SqlDbType.VarChar);
		command.Parameters.Add("@address", SqlDbType.Text);
		command.Parameters.Add("@xemail", SqlDbType.VarChar);
		command.Parameters.Add("@xmobile", SqlDbType.VarChar);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 10);
		command.Parameters["@xname"].Value = c_app.xname;
		command.Parameters["@address"].Value = c_app.address;
		command.Parameters["@xemail"].Value = c_app.xemail;
		command.Parameters["@xmobile"].Value = c_app.xmobile;
		command.Parameters["@log_staff"].Value = c_app.log_staff;
		command.Parameters["@visible"].Value = c_app.visible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addInventor(pt.Inventor c_inv)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO inventor (xname,address,xemail,xmobile,log_staff,visible) VALUES (@xname,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@xname", SqlDbType.VarChar);
		command.Parameters.Add("@address", SqlDbType.Text);
		command.Parameters.Add("@xemail", SqlDbType.VarChar);
		command.Parameters.Add("@xmobile", SqlDbType.VarChar);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 10);
		command.Parameters["@xname"].Value = c_inv.xname;
		command.Parameters["@address"].Value = c_inv.address;
		command.Parameters["@xemail"].Value = c_inv.xemail;
		command.Parameters["@xmobile"].Value = c_inv.xmobile;
		command.Parameters["@log_staff"].Value = c_inv.log_staff;
		command.Parameters["@visible"].Value = c_inv.visible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addPriority_info(pt.Priority_info c_pri)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO priority_info (countryID,app_no,xdate,log_staff,xvisible) VALUES (@countryID,@app_no,@xdate,@log_staff,@xvisible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@countryID", SqlDbType.VarChar, 50);
		command.Parameters.Add("@app_no", SqlDbType.VarChar);
		command.Parameters.Add("@xdate", SqlDbType.VarChar, 50);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 20);
		command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);
		command.Parameters["@countryID"].Value = c_pri.countryID;
		command.Parameters["@app_no"].Value = c_pri.app_no;
		command.Parameters["@xdate"].Value = c_pri.xdate;
		command.Parameters["@log_staff"].Value = c_pri.log_staff;
		command.Parameters["@xvisible"].Value = c_pri.xvisible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addAssignment_info(pt.Assignment_info c_ass)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO assignment_info (assignee_name,assignee_address,assignor_name,assignor_address,log_staff,xvisible) VALUES (@assignee_name,@assignee_address,@assignor_name,@assignor_address,@log_staff,@xvisible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@assignee_name", SqlDbType.VarChar);
		command.Parameters.Add("@assignee_address", SqlDbType.Text);
		command.Parameters.Add("@assignor_name", SqlDbType.VarChar);
		command.Parameters.Add("@assignor_address", SqlDbType.Text);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 50);
		command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);
		command.Parameters["@assignee_name"].Value = c_ass.assignee_name;
		command.Parameters["@assignee_address"].Value = c_ass.assignee_address;
		command.Parameters["@assignor_name"].Value = c_ass.assignor_name;
		command.Parameters["@assignor_address"].Value = c_ass.assignor_address;
		command.Parameters["@log_staff"].Value = c_ass.log_staff;
		command.Parameters["@xvisible"].Value = c_ass.visible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addPt(pt.PtInfo c_pt)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO pt_Info (reg_number,xtype,title_of_invention,pt_class,loa_doc,doa_doc,ns_doc,pd_doc,rep_pic,rep2_pic,rep3_pic,rep4_pic,log_staff,reg_date,xvisible) VALUES (@reg_number,@xtype,@title_of_invention,@pt_class,@loa_doc,@doa_doc,@ns_doc,@pd_doc,@rep_pic,@rep2_pic,@rep3_pic,@rep4_pic,@log_staff,@reg_date,@xvisible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@reg_number", SqlDbType.NVarChar, 50);
		command.Parameters.Add("@xtype", SqlDbType.NVarChar);
		command.Parameters.Add("@title_of_invention", SqlDbType.NVarChar);
		command.Parameters.Add("@pt_class", SqlDbType.NVarChar, 50);
		command.Parameters.Add("@loa_doc", SqlDbType.Text);
		command.Parameters.Add("@doa_doc", SqlDbType.Text);
		command.Parameters.Add("@ns_doc", SqlDbType.Text);
		command.Parameters.Add("@pd_doc", SqlDbType.Text);
		command.Parameters.Add("@rep_pic", SqlDbType.Text);
		command.Parameters.Add("@rep2_pic", SqlDbType.Text);
		command.Parameters.Add("@rep3_pic", SqlDbType.Text);
		command.Parameters.Add("@rep4_pic", SqlDbType.Text);
		command.Parameters.Add("@log_staff", SqlDbType.NVarChar, 50);
		command.Parameters.Add("@reg_date", SqlDbType.NVarChar, 50);
		command.Parameters.Add("@xvisible", SqlDbType.NVarChar, 10);
		command.Parameters["@reg_number"].Value = c_pt.reg_number;
		command.Parameters["@xtype"].Value = c_pt.xtype;
		command.Parameters["@title_of_invention"].Value = c_pt.title_of_invention;
		command.Parameters["@pt_class"].Value = c_pt.pt_class;
		command.Parameters["@loa_doc"].Value = "";
		command.Parameters["@doa_doc"].Value = "";
		command.Parameters["@ns_doc"].Value = "";
		command.Parameters["@pd_doc"].Value = "";
		command.Parameters["@rep_pic"].Value = "";
		command.Parameters["@rep2_pic"].Value = "";
		command.Parameters["@rep3_pic"].Value = "";
		command.Parameters["@rep4_pic"].Value = "";
		command.Parameters["@log_staff"].Value = c_pt.log_staff;
		command.Parameters["@reg_date"].Value = c_pt.reg_date;
		command.Parameters["@xvisible"].Value = c_pt.xvisible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addRepresentative(pt.Representative c_rep)
	{
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO representative (agent_code,xname,nationality,country,state,address,xemail,xmobile,log_staff,visible) VALUES (@agent_code,@xname,@nationality,@country,@state,@address,@xemail,@xmobile,@log_staff,@visible) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@agent_code", SqlDbType.VarChar);
		command.Parameters.Add("@xname", SqlDbType.NVarChar);
		command.Parameters.Add("@nationality", SqlDbType.NVarChar, 50);
		command.Parameters.Add("@country", SqlDbType.VarChar, 50);
		command.Parameters.Add("@state", SqlDbType.VarChar, 50);
		command.Parameters.Add("@address", SqlDbType.Text);
		command.Parameters.Add("@xemail", SqlDbType.NVarChar);
		command.Parameters.Add("@xmobile", SqlDbType.VarChar);
		command.Parameters.Add("@log_staff", SqlDbType.VarChar, 50);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 10);
		command.Parameters["@agent_code"].Value = c_rep.agent_code;
		command.Parameters["@xname"].Value = c_rep.xname;
		command.Parameters["@nationality"].Value = c_rep.nationality;
		command.Parameters["@country"].Value = c_rep.country;
		command.Parameters["@state"].Value = c_rep.state;
		command.Parameters["@address"].Value = c_rep.address;
		command.Parameters["@xemail"].Value = c_rep.xemail;
		command.Parameters["@xmobile"].Value = c_rep.xmobile;
		command.Parameters["@log_staff"].Value = c_rep.log_staff;
		command.Parameters["@visible"].Value = c_rep.visible;
		string succ = command.ExecuteScalar().ToString();
		connection.Close();
		return succ;
	}
	public string addPwallet(string serverpath, string validationID, string agent_code, string amt, string log_officer)
	{
		string connectionString = this.Connect();
		string str3 = DateTime.Today.Date.ToString("yyyy-MM-dd");
		string str4 = "1";
		string str5 = "1";
		string str6 = "1";
		string str7 = "Fresh";
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = connection.CreateCommand();
		command.CommandText = "INSERT INTO pwallet (validationID,applicantID,log_officer,amt,stage,status,data_status,reg_date,visible )  VALUES ( @validationID,@applicantID,@log_officer,@amt,@stage,@status,@data_status,@regdate,@visible ) SELECT SCOPE_IDENTITY()";
		connection.Open();
		command.Parameters.Add("@validationID", SqlDbType.VarChar, 50);
		command.Parameters.Add("@applicantID", SqlDbType.VarChar, 50);
		command.Parameters.Add("@log_officer", SqlDbType.VarChar, 50);
		command.Parameters.Add("@amt", SqlDbType.VarChar, 50);
		command.Parameters.Add("@stage", SqlDbType.NChar, 10);
		command.Parameters.Add("@status", SqlDbType.VarChar, 20);
		command.Parameters.Add("@data_status", SqlDbType.VarChar, 50);
		command.Parameters.Add("@regdate", SqlDbType.VarChar, 50);
		command.Parameters.Add("@visible", SqlDbType.VarChar, 1);
		command.Parameters["@validationID"].Value = validationID;
		command.Parameters["@applicantID"].Value = agent_code;
		command.Parameters["@log_officer"].Value = log_officer;
		command.Parameters["@amt"].Value = amt;
		command.Parameters["@stage"].Value = str6;
		command.Parameters["@status"].Value = str5;
		command.Parameters["@data_status"].Value = str7;
		command.Parameters["@regdate"].Value = str3;
		command.Parameters["@visible"].Value = str4;
		return command.ExecuteScalar().ToString();
	}
	public void cleanseTmByValidation(string serverpath, string vid)
	{
		string id = "0";
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = new SqlCommand("SELECT * from pwallet where validationID='" + vid + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			reader["stage"].ToString();
			id = reader["ID"].ToString();
		}
		reader.Close();
		if (id != "0")
		{
			SqlConnection connection2 = new SqlConnection(connectionString);
			SqlCommand command2 = new SqlCommand("DELETE from pwallet where validationID='" + vid + "'", connection2);
			connection2.Open();
			command2.ExecuteNonQuery();
			connection2.Close();
			this.flushApplicant(id);
			this.flushPt_info(serverpath, id);
			this.flushAddress_service(id);
			this.flushRepresentative(id);
			this.flushAddress(id);
		}
	}
	public void flushAddress(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from address where log_staff='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushAddress_service(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from address_service where log_staff='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushApplicant(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from applicant where log_staff='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushPt_info(string serverpath, string id)
	{
		long markID = 0L;
		string connectionString = this.Connect();
		SqlConnection connection = new SqlConnection(connectionString);
		SqlCommand command = new SqlCommand("SELECT xID from pt_info where log_staff='" + id + "'", connection);
		connection.Open();
		SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
		while (reader.Read())
		{
			markID = Convert.ToInt64(reader["xID"]);
		}
		reader.Close();
		SqlConnection connection2 = new SqlConnection(connectionString);
		SqlCommand command2 = new SqlCommand("DELETE from pt_info where log_staff='" + id + "'", connection2);
		connection2.Open();
		command2.ExecuteNonQuery();
		connection2.Close();
		if (markID > 0L)
		{
			this.doDeleteDir(serverpath, markID);
		}
	}
	public void flushRepresentative(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from representative where log_staff='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushPwalletByID(string id)
	{
		string connectionString = this.Connect();
		if (id != "0" && id != "")
		{
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = new SqlCommand("DELETE from pwallet where ID='" + id + "'", connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
	}
	public void flushAddress_serviceByID(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from address_service where ID='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushApplicantByID(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from applicant where ID='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushMark_infoByID(string serverpath, string id)
	{
		string connectionString = this.Connect();
		SqlConnection connection2 = new SqlConnection(connectionString);
		SqlCommand command2 = new SqlCommand("DELETE from pt_info where xID='" + id + "'", connection2);
		connection2.Open();
		command2.ExecuteNonQuery();
		connection2.Close();
		if (Convert.ToInt64(id) > 0L)
		{
			this.doDeleteDir(serverpath, Convert.ToInt64(id));
		}
	}
	public void flushRepresentativeByID(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from representative where ID='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void flushAddressByID(string id)
	{
		SqlConnection connection = new SqlConnection(this.Connect());
		SqlCommand command = new SqlCommand("DELETE from address where ID='" + id + "'", connection);
		connection.Open();
		command.ExecuteNonQuery();
		connection.Close();
	}
	public void doDeleteDir(string serverpath, long markID)
	{
		if (markID > 0L)
		{
			string path = serverpath + "admin/tm/docz/" + markID.ToString() + "/";
			string str2 = serverpath + "admin/tm/Picz/" + markID.ToString() + "/";
			try
			{
				if (Directory.Exists(path))
				{
					string[] files = Directory.GetFiles(path);
					for (int i = 0; i < files.Length; i++)
					{
						string str3 = files[i];
						File.Delete(str3);
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (Directory.Exists(str2))
				{
					string[] files = Directory.GetFiles(str2);
					for (int i = 0; i < files.Length; i++)
					{
						string str4 = files[i];
						File.Delete(str4);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}
	public void doDeleteCurrentDir(string path)
	{
		try
		{
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path);
				for (int i = 0; i < files.Length; i++)
				{
					string str3 = files[i];
					File.Delete(str3);
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			if (Directory.Exists(path))
			{
				Directory.Delete(path);
			}
		}
	}
}
