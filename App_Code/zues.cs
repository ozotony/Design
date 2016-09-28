using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public class zues
{
    public int e_regadmin(string xname, string xpass, string xrole, string xemail, string telephone1, string telephone2, string xsection, string pwalletID, string xID, string visible)
    {
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "UPDATE xadminz_pt SET xname=@xname,xpass=@xpass,xroleID=@xroleID,xemail=@xemail,xtelephone1=@xtelephone1,xtelephone2=@xtelephone2,xsection=@xsection,xlog_officer=@pwalletID,xvisible=@xvisible WHERE xID=@xID ";
        connection.Open();
        command.Parameters.Add("@xID", SqlDbType.BigInt);
        command.Parameters.Add("@xname", SqlDbType.NVarChar);
        command.Parameters.Add("@xpass", SqlDbType.Text);
        command.Parameters.Add("@xroleID", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@xemail", SqlDbType.Text);
        command.Parameters.Add("@xtelephone1", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@xtelephone2", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@xsection", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@pwalletID", SqlDbType.NVarChar, 50);
        command.Parameters.Add("@xvisible", SqlDbType.NVarChar, 1);
        command.Parameters["@xID"].Value = xID;
        command.Parameters["@xname"].Value = xname;
        command.Parameters["@xpass"].Value = xpass;
        command.Parameters["@xroleID"].Value = xrole;
        command.Parameters["@xemail"].Value = xemail;
        command.Parameters["@xtelephone1"].Value = telephone1;
        command.Parameters["@xtelephone2"].Value = telephone2;
        command.Parameters["@xsection"].Value = xsection;
        command.Parameters["@pwalletID"].Value = pwalletID;
        command.Parameters["@xvisible"].Value = visible;
        int num = command.ExecuteNonQuery();
        connection.Close();
        if (num > 0)
        {
            num = Convert.ToInt32(xID);
        }
        return num;
    }

    public int updatepwalletID(string xid, string Sys_ID)
    {
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("UPDATE pwallet SET rd_no='" + Sys_ID + "' WHERE ID='" + xid + "'  ", connection);
        connection.Open();
        int num = command.ExecuteNonQuery();
        connection.Close();
        return num;
    }

    public int getMaxRdno()
    {
        int num = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("select  max(convert(int,rd_no) ) as max_sysid from  pwallet ", connection);
        connection.Open();// command.CommandTimeout = 600;
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            num = Convert.ToInt32(reader["max_sysid"]);
        }
        reader.Close();
        return num;
    }
    public Adminz getAdminDetails(string ID)
    {
        Adminz adminz = new Adminz();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * from xadminz_pt where xID='" + ID + "'", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            adminz.xID = reader["xID"].ToString();
            adminz.xroleID = reader["xroleID"].ToString();
            adminz.xname = reader["xname"].ToString();
            adminz.xemail = reader["xemail"].ToString();
            adminz.xpass = reader["xpass"].ToString();
            adminz.xtelephone1 = reader["xtelephone1"].ToString();
            adminz.xtelephone2 = reader["xtelephone2"].ToString();
            adminz.xsection = reader["xsection"].ToString();
            adminz.xlog_officer = reader["xlog_officer"].ToString();
            adminz.xreg_date = reader["xreg_date"].ToString();
            adminz.xvisible = reader["xvisible"].ToString();
        }
        reader.Close();
        return adminz;
    }

    public string getAdmiPriv(string ID)
    {
        string priv = "0";
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT priv from roles where ID='" + ID + "'", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            priv = reader["priv"].ToString();
        }
        reader.Close();
        return priv;
    }
    public Adminz getTopAdminDetails()
    {
        Adminz adminz = new Adminz();
        SqlConnection connection = new SqlConnection(this.Connect());
        string cmdText = "SELECT top 1 * from xadminz_pt";
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            adminz.xID = reader["xID"].ToString();
            adminz.xroleID = reader["xroleID"].ToString();
            adminz.xname = reader["xname"].ToString();
            adminz.xemail = reader["xemail"].ToString();
            adminz.xpass = reader["xpass"].ToString();
            adminz.xtelephone1 = reader["xtelephone1"].ToString();
            adminz.xtelephone2 = reader["xtelephone2"].ToString();
            adminz.xsection = reader["xsection"].ToString();
            adminz.xlog_officer = reader["xlog_officer"].ToString();
            adminz.xreg_date = reader["xreg_date"].ToString();
            adminz.xvisible = reader["xvisible"].ToString();
        }
        reader.Close();
        return adminz;
    }

    public string addAdminLog(string adminID, string ip_addy, string remote_host, string remote_user, string server_name, string server_url)
    {
        string log_date = DateTime.Today.Date.ToString("yyyy-MM-dd");
        string log_time = DateTime.Now.ToLongTimeString();

        string connectionString = this.Connect();
        string succ = "0";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO admin_lg (adminID,ip_addy,remote_host,remote_user,server_name,server_url,log_date,log_time) VALUES (@adminID,@ip_addy,@remote_host,@remote_user,@server_name,@server_url,@log_date,@log_time) SELECT SCOPE_IDENTITY()";
        connection.Open();
        command.Parameters.Add("@adminID", SqlDbType.VarChar, 200);
        command.Parameters.Add("@ip_addy", SqlDbType.Text);
        command.Parameters.Add("@remote_host", SqlDbType.Text);
        command.Parameters.Add("@remote_user", SqlDbType.Text);
        command.Parameters.Add("@server_name", SqlDbType.Text);
        command.Parameters.Add("@server_url", SqlDbType.Text);
        command.Parameters.Add("@log_date", SqlDbType.VarChar, 200);
        command.Parameters.Add("@log_time", SqlDbType.VarChar, 200);
        command.Parameters["@adminID"].Value = adminID;
        command.Parameters["@ip_addy"].Value = ip_addy;
        command.Parameters["@remote_host"].Value = remote_host;
        command.Parameters["@remote_user"].Value = remote_user;
        command.Parameters["@server_name"].Value = server_name;
        command.Parameters["@server_url"].Value = server_url;
        command.Parameters["@log_date"].Value = log_date;
        command.Parameters["@log_time"].Value = log_time;
        succ = command.ExecuteScalar().ToString();
        connection.Close();
        return succ;
    }


    public string a_regadmin(string xname, string xrole, string xemail, string telephone1, string telephone2, string xsection, string pwalletID, string pass)
    {
        string connectionString = this.Connect();
        string succ = "";
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT into xadminz_pt (xroleID ,xname,xemail,xpass,xtelephone1,xtelephone2,xsection,xlog_officer,xreg_date,xvisible) VALUES (@xrole,@xname,@xemail,@xpass,@xtelephone1,@xtelephone2,@xsection,@xlog_officer,@xreg_date,@xvisible) SELECT SCOPE_IDENTITY()";
        connection.Open();

        command.Parameters.Add("@xname", SqlDbType.VarChar);
        command.Parameters.Add("@xrole", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xemail", SqlDbType.Text);
        command.Parameters.Add("@xpass", SqlDbType.Text);
        command.Parameters.Add("@xtelephone1", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xtelephone2", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xsection", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xlog_officer", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xreg_date", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);

        command.Parameters["@xname"].Value = xname;
        command.Parameters["@xrole"].Value = xrole;
        command.Parameters["@xemail"].Value = xemail;
        command.Parameters["@xpass"].Value = pass;
        command.Parameters["@xtelephone1"].Value = telephone1;
        command.Parameters["@xtelephone2"].Value = telephone2;
        command.Parameters["@xsection"].Value = xsection;
        command.Parameters["@xlog_officer"].Value = pwalletID;
        command.Parameters["@xreg_date"].Value = date;
        command.Parameters["@xvisible"].Value = "1";

        succ = command.ExecuteScalar().ToString();
        connection.Close();
        return succ;
    }

    public string a_tm_office(string pwalletID, string admin_status, string data_status, string xcomment, string xdoc1, string xdoc2, string xdoc3, string xofficer)
    {
        string succ = "";
        string connectionString = this.Connect();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO pt_office (pwalletID,admin_status,data_status,xcomment,xdoc1,xdoc2,xdoc3,xofficer,reg_date,xvisible) VALUES (@pwalletID,@admin_status,@data_status,@xcomment,@xdoc1,@xdoc2,@xdoc3,@xofficer,@reg_date,@xvisible) SELECT SCOPE_IDENTITY()";
        connection.Open();

        string xdate = DateTime.Now.ToString("yyyy-MM-dd");
        xdoc1 = xdoc1.Replace(" ", "_"); xdoc2 = xdoc2.Replace(" ", "_"); xdoc3 = xdoc3.Replace(" ", "_");

        command.Parameters.Add("@pwalletID", SqlDbType.VarChar, 50);
        command.Parameters.Add("@admin_status", SqlDbType.VarChar, 50);
        command.Parameters.Add("@data_status", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xcomment", SqlDbType.Text);
        command.Parameters.Add("@xdoc1", SqlDbType.Text);
        command.Parameters.Add("@xdoc2", SqlDbType.Text);
        command.Parameters.Add("@xdoc3", SqlDbType.Text);
        command.Parameters.Add("@xofficer", SqlDbType.VarChar, 50);
        command.Parameters.Add("@reg_date", SqlDbType.VarChar, 50);
        command.Parameters.Add("@xvisible", SqlDbType.VarChar, 10);

        command.Parameters["@pwalletID"].Value = pwalletID;
        command.Parameters["@admin_status"].Value = admin_status;
        command.Parameters["@data_status"].Value = data_status;
        command.Parameters["@xcomment"].Value = xcomment;
        command.Parameters["@xdoc1"].Value = xdoc1;
        command.Parameters["@xdoc2"].Value = xdoc2;
        command.Parameters["@xdoc3"].Value = xdoc3;
        command.Parameters["@xofficer"].Value = xofficer;
        command.Parameters["@reg_date"].Value = xdate;
        command.Parameters["@xvisible"].Value = "1";
        succ = command.ExecuteScalar().ToString();
        connection.Close();

        if (succ == "0")
        {
            return "0";
        }
        if (!(Convert.ToInt32(this.e_PwalletStatus(pwalletID, admin_status, data_status)).ToString() != "0"))
        {
            succ = "0";
        }
        return succ;
    }

    public string a_xadminz(string uname, string xpass, string serverpath)
    {
        string keydir = serverpath + "\\Handlers\\bf.kez"; string file_string = ""; int file_len = 1024;
        if (File.Exists(keydir))
        {
            StreamReader streamReader = new StreamReader(keydir, true);
            file_string = streamReader.ReadToEnd();
            streamReader.Close();
            if (file_string != null)
            {
                string bitStrengthString = file_string.Substring(0, file_string.IndexOf("</BitStrength>") + 14);
                file_string = file_string.Replace(bitStrengthString, "");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        List<Adminz> lt_adz = new List<Adminz>();
        string connectionString = this.Connect();
        string xID = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("select xID,xemail,xpass from xadminz_pt where xvisible='1' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            Adminz ad = new Adminz();
            ad.xID = reader["xID"].ToString();
            ad.xemail = reader["xemail"].ToString();
            ad.xpass = reader["xpass"].ToString();
            lt_adz.Add(ad);
        }
        reader.Close();
        string dpass = ""; string dmail = ""; Odyssey ody = new Odyssey();
        for (int i = 0; i < lt_adz.Count; i++)
        {
            dmail = ody.DecryptString(lt_adz[i].xemail, file_len, file_string);
            dpass = ody.DecryptString(lt_adz[i].xpass, file_len, file_string);
            //dmail = lt_adz[i].xemail;
           // dpass = lt_adz[i].xpass;
            if ((uname == dmail) && (xpass == dpass))
            {
                xID = lt_adz[i].xID.ToString();
            }
        }
        return xID;
    }
    public string Connect()
    {
        return ConfigurationManager.ConnectionStrings["cldConnectionString"].ConnectionString;
    }


    public string Connect2()
    {
        return ConfigurationManager.ConnectionStrings["xhomeConnectionString"].ConnectionString;
    }

    public int e_PwalletStatus(string xID, string status, string data_status)
    {
        int num;
        string connectionString = this.Connect();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "UPDATE pwallet SET status=@status,data_status=@data_status WHERE ID=@ID ";
        connection.Open();
        command.Parameters.Add("@ID", SqlDbType.BigInt);
        command.Parameters.Add("@status", SqlDbType.NVarChar, 20);
        command.Parameters.Add("@data_status", SqlDbType.NVarChar, 50);
        command.Parameters["@ID"].Value = Convert.ToInt64(xID);
        command.Parameters["@status"].Value = status;
        command.Parameters["@data_status"].Value = data_status;
        num = command.ExecuteNonQuery();
        connection.Close();
        return num;
    }
       
    public string GetAddressTags(string select_search)
    {
        return "";
    }

    public List<PtInfo> getCriAccpetancePtInfoRS(string stage, string data_status)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (data_status == "Rejected")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status='" + stage + "' AND ( pwallet.data_status = 'Rejected')  ORDER BY xID DESC";
        }
        else if (data_status == "Registrable")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status='" + stage + "' AND ( pwallet.data_status = 'Registrable')  ORDER BY xID DESC";
        }
        else if (data_status == "Accepted")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status >'" + stage + "' AND pwallet.data_status='" + data_status + "' ORDER BY xID DESC";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public List<PtInfo> getCriRegisteredPtInfoRS(string stage, string data_status)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (data_status == "Registered")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status='" + stage + "' AND ( pwallet.data_status = 'Registered')  ORDER BY xID DESC";
        }
        else if (data_status == "Deferred")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status='" + stage + "' AND ( pwallet.data_status = 'Deferred')  ORDER BY xID DESC";
        }
        else if (data_status == "Accepted")
        {
            cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status ='" + stage + "' AND pwallet.data_status='" + data_status + "' ORDER BY xID DESC";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
            {
                //xID = reader["xID"].ToString(),
                //reg_number = reader["reg_number"].ToString(),
                //xtype = reader["xtype"].ToString(),
                //title_of_invention = reader["title_of_invention"].ToString(),
                //pt_class = reader["pt_class"].ToString(),
                //spec_doc = reader["spec_doc"].ToString(),
                //loa_no = reader["loa_no"].ToString(),
                //loa_doc = reader["loa_doc"].ToString(),
                //claim_no = reader["claim_no"].ToString(),
                //claim_doc = reader["claim_doc"].ToString(),
                //pct_no = reader["pct_no"].ToString(),
                //pct_doc = reader["pct_doc"].ToString(),
                //doa_no = reader["doa_no"].ToString(),
                //doa_doc = reader["doa_doc"].ToString(),
                //log_staff = reader["log_staff"].ToString(),
                //reg_date = reader["reg_date"].ToString(),
                //xvisible = reader["xvisible"].ToString()

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

    public List<PtInfo> getPtInfoByDataStatusRS(string stage, string data_status)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("select * from pt_info LEFT OUTER JOIN pt_office ON pt_info.log_staff=pt_office.pwalletID WHERE pt_office.admin_status='" + stage + "' AND pt_office.data_status='" + data_status + "' ORDER BY xID DESC", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public List<PtInfo> getAdminSearchPtInfoRS(string status, string data_status, string criteria, List<string> fulltext, string dateFrom, string dateTo)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        string cmdText = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        int num = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
        if (criteria == "product_title")
        {
            num = fulltext.Count - 1;
            if ((status == "1") && (data_status == "Fresh"))
            {
                str2 = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND (pwallet.data_status='Fresh' OR pwallet.data_status='Invalid') AND ";
            }
            if ((status == "3") && (data_status != "Rejected"))
            {
                str2 = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND (pwallet.data_status='Registrable' OR pwallet.data_status='Non-registrable') AND ";
            }
            else
            {
                str2 = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' AND ";
            }
            for (int i = 0; i < fulltext.Count; i++)
            {
                if (fulltext.Count == 1)
                {
                    str3 = str3 + " ( title_of_invention like '%" + fulltext[i] + "%' ) ";
                }
                else if (num == i)
                {
                    str3 = str3 + " ( title_of_invention like '%" + fulltext[i] + "%' ) ";
                }
                else
                {
                    str3 = str3 + " ( title_of_invention like '%" + fulltext[i] + "%' ) OR";
                }
            }
            str4 = "AND pwallet.reg_date between '" + dateFrom + "' AND '" + dateTo + "'  ORDER BY xID ASC";
            cmdText = str2 + str3 + str4;
        }

        else if (criteria == "app_number")
        {
            if ((status == "1") && (data_status == "Fresh"))
            {
                cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND (pwallet.data_status='Fresh' OR pwallet.data_status='Invalid') AND pt_info.reg_number like  '%" + fulltext[0] + "%' AND pwallet.reg_date between '" + dateFrom + "' AND '" + dateTo + "'  ORDER BY xID ASC ";
            }
            else if ((status == "3") && (data_status != "Rejected"))
            {
                cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND (pwallet.data_status='Registrable' OR pwallet.data_status='Non-registrable') AND pt_info.reg_number like  '%" + fulltext[0] + "%' AND pwallet.reg_date between '" + dateFrom + "' AND '" + dateTo + "'  ORDER BY xID ASC ";
            }
            else
            {
                cmdText = "select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' AND pt_info.reg_number like  '%" + fulltext[0] + "%' AND pwallet.reg_date between '" + dateFrom + "' AND '" + dateTo + "'  ORDER BY xID ASC ";
            }
        }

        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public Int64 getPublishPtInfoRSCnt(string status, string data_status)
    {
        Int64 cnt = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE (pwallet.stage='5' AND pwallet.status = '" + status + "' AND pwallet.data_status = '" + data_status + "') OR (pwallet.stage='5' AND pwallet.status ='6') OR (pwallet.stage='5' AND pwallet.status ='7') OR (pwallet.stage='5' AND pwallet.status ='8') OR (pwallet.stage='5' AND pwallet.status ='9') OR (pwallet.stage='5' AND pwallet.status ='10') ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {

            cnt = Convert.ToInt64(reader["cnt"]);
        }
        reader.Close();
        return cnt;
    }

    public List<PtInfo> getPtInfoByUserID(string ID)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_info WHERE xID='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public Int64 getPtInfoRSCnt(string status, string data_status)
    {
        Int64 cnt = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
        if ((status == "3") && (data_status != "Rejected"))
        {
          // SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "'     AND ((pwallet.data_status='Registrable') or (pwallet.data_status='Non-registrable') ) ", connection);

            SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID inner join applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status ='" + status + "'   AND pwallet.data_status='" + data_status + "'    ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                cnt = Convert.ToInt64(reader["cnt"]);
            }
            reader.Close();
        }
        else if ((status == "1") && (data_status == "Fresh"))
        {
           // SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID inner join applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) ", connection);
            SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' ", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                cnt = Convert.ToInt64(reader["cnt"]);
            }
            reader.Close();
        }
        else
        {
            SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                cnt = Convert.ToInt64(reader["cnt"]);
            }
            reader.Close();
        }
        return cnt;
    }

    public Int64 getPtInfoRSCnt2(string status, string data_status)
    {
        Int64 cnt = 0;
        SqlConnection connection = new SqlConnection(this.Connect());
       
            SqlCommand command = new SqlCommand("select Count(*) AS cnt from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND  pwallet.data_status in ('Registered','Accepted') ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                cnt = Convert.ToInt64(reader["cnt"]);
            }
            reader.Close();
        
        return cnt;
    }

    public List<XrowCount> getNew_RowCount(string status, string data_status)
    {
        List<XrowCount> list = new List<XrowCount>();


       // new XObjs.Office_view();
        SqlConnection connection = new SqlConnection(this.Connect());
        //  SqlCommand command = new SqlCommand(string.Concat(new object[] { "WITH RSTbl AS (select  pwallet.ID 'ID',applicant.xname,mark_info.national_classID 'class',mark_info.xID,mark_info.reg_number 'reg_no',mark_info.product_title,tm_type.type 'tm_type',pwallet.validationID 'oai_no', ISNULL(pwallet.data_status,'None') 'xstat', mark_info.reg_date 'reg_dt',mark_info.log_staff, ROW_NUMBER() OVER (ORDER BY pwallet.ID) AS 'RowRank'  from mark_info LEFT OUTER JOIN pwallet ON mark_info.log_staff=pwallet.ID   LEFT OUTER JOIN tm_type ON tm_type.xID=mark_info.tm_typeID  LEFT OUTER JOIN applicant ON applicant.log_staff=pwallet.ID    WHERE   pwallet.stage='5' AND pwallet.status<>'33' AND pwallet.status<>'22'  AND pwallet.data_status<>'kiv' AND pwallet.data_status<>'acc_printed' AND pwallet.data_status<>'Withdraw' AND CAST(pwallet.status AS INT)>=5  )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '", start, "' AND '", limit, "' order by ID DESC " }), connection)

        SqlCommand command = new SqlCommand(string.Concat(new object[] { "select ROW_NUMBER() OVER (ORDER BY pwallet.ID) AS 'RowRank', pwallet.ID 'tblID'  from  pwallet  LEFT OUTER JOIN pt_info ON pt_info.log_staff=pwallet.ID  inner join applicant on pwallet.applicantID=applicant.ID      WHERE pwallet.stage='5' AND pwallet.status='", status, "' AND pwallet.data_status='", data_status, "'   " }), connection)
        {
            CommandTimeout = 300
        };
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            XrowCount item = new XrowCount
            {
                RowRanks = reader["RowRank"].ToString(),
                Tblld = reader["tblID"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;

    }

    public List<PtInfo> getPtInfoRSX(string status, string data_status, string start, string limit)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        if ((status == "3") && (data_status != "Rejected"))
        {
          //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status  from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    ) order by pwallet.rd_no desc  ", connection);

          //  SqlCommand command = new SqlCommand(string.Concat(new object[] { "Select * from (select pwallet.ID, pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Registrable') or (pwallet.data_status='Non-registrable') ) ) as Tab WHERE Tab.ID BETWEEN '", start, "' AND '", limit, "' order BY rtm ASC " }), connection);


            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            string voffice="";
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "") {
                //    voffice=(getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                   // Office = voffice,
                    Office = voffice,
                    Sn=Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else if ((status == "1") && (data_status == "SearchAll"))
        {
            // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status  from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' order by pwallet.rd_no desc    ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }

        else if ((status == "1") && (data_status == "Fresh"))
        {
           // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

          //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    )  order by pwallet.rd_no desc  ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else
        {
           // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

        //    SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    )  order by pwallet.rd_no desc  ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        return list;
    }

    public List<PtInfo> getPtInfoRSX4(string status, string data_status, string start, string limit)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        if ((status == "3") && (data_status != "Rejected"))
        {
            //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status  from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND   pwallet.data_status in ('Registered','Accepted') order by pwallet.rd_no desc  ", connection);

            //  SqlCommand command = new SqlCommand(string.Concat(new object[] { "Select * from (select pwallet.ID, pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Registrable') or (pwallet.data_status='Non-registrable') ) ) as Tab WHERE Tab.ID BETWEEN '", start, "' AND '", limit, "' order BY rtm ASC " }), connection);


            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            string voffice = "";
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "") {
                //    voffice=(getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    // Office = voffice,
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else if ((status == "1") && (data_status == "SearchAll"))
        {
            // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status  from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' order by pwallet.rd_no desc    ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }

        else if ((status == "1") && (data_status == "Fresh"))
        {
            // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            //  SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status='" + data_status + "' )    )  order by pwallet.rd_no desc  ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else
        {
            // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            //    SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN applicant on applicant.log_staff=pwallet.ID WHERE pwallet.stage='5' AND ((pwallet.status='" + status + "') )  AND ((pwallet.data_status= '" + data_status + "' )   ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand("select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff,pwallet.applicantID,applicant.xname,pwallet.validationID ,pwallet.rd_no,pwallet.data_status from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID  inner join applicant on applicant.log_staff=pwallet.ID  WHERE pwallet.stage='5' AND    pwallet.data_status in ('Registered','Accepted')  order by pwallet.rd_no desc  ", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int vsn = 0;
            while (reader.Read())
            {
                vsn = vsn + 1;
                string voffice = "";
                //if (getPtOfficeByMID(reader["log_staff"].ToString()) != "")
                //{
                //    voffice = (getPtOfficeByMID(reader["log_staff"].ToString()));
                //}
                //else
                //{
                //    voffice = "None";
                //}

                if (reader["data_status"].ToString() != "")
                {
                    voffice = reader["data_status"].ToString();
                }
                else
                {
                    voffice = "None";
                }
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString(),
                    ApplicantId = "OAI/DS/" + reader["validationID"].ToString(),
                    ApplicantName = reader["xname"].ToString(),
                    Office = voffice,
                    Sn = Convert.ToString(vsn),
                    Rdno = reader["rd_no"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        return list;
    }

    public List<PtInfo> getPtInfoRSX2(string status, string data_status, int start, int limit)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        if ((status == "3") && (data_status != "Rejected"))
        {
            SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Registrable') or (pwallet.data_status='Non-registrable') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

          //  SqlCommand command = new SqlCommand(string.Concat(new object[] { "Select * from (select pwallet.ID, pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "'  AND pwallet.data_status='", data_status, "'  ) as Tab WHERE Tab.ID BETWEEN '", start, "' AND '", limit, "'  " }), connection);


            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else if ((status == "1") && (data_status == "Fresh"))
        {
            SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND ((pwallet.data_status='Fresh') or (pwallet.data_status='Invalid') ) )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        else
        {
           // SqlCommand command = new SqlCommand("WITH RSTbl AS (select pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff, ROW_NUMBER() OVER (ORDER BY pt_info.xID) AS 'RowRank' from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "' AND pwallet.data_status='" + data_status + "' )SELECT * FROM RSTbl  WHERE RowRank BETWEEN '" + start + "' AND '" + limit + "' ", connection);
            SqlCommand command = new SqlCommand(string.Concat(new object[] { "Select * from (select pwallet.ID, pt_info.xID,pt_info.reg_number,pt_info.title_of_invention,pt_info.xtype,pt_info.reg_date,pt_info.log_staff from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.stage='5' AND pwallet.status='" + status + "'  AND pwallet.data_status='", data_status, "'  ) as Tab WHERE Tab.ID BETWEEN '", start, "' AND '", limit, "'  " }), connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                PtInfo item = new PtInfo
                {
                    xID = reader["xID"].ToString(),
                    reg_number = reader["reg_number"].ToString(),
                    xtype = reader["xtype"].ToString(),
                    title_of_invention = reader["title_of_invention"].ToString(),
                    log_staff = reader["log_staff"].ToString(),
                    reg_date = reader["reg_date"].ToString()
                };
                list.Add(item);
            }
            reader.Close();
        }
        return list;
    }

    public List<PtInfo> getPtInfoRS(string stage)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("select * from pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID WHERE pwallet.status='" + stage + "' ORDER BY xID DESC", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public List<PtInfo> getPtInfoSlipPlusRS(string stage)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT pt_info.*  FROM pwallet LEFT OUTER JOIN pt_info ON pwallet.ID=pt_info.log_staff WHERE pwallet.status >= '" + stage + "' AND pt_info.log_staff IN (Select ID  FROM pwallet) ORDER BY ID DESC", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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
    public int addReversal(PtOffice c_tm_office)
    {
        string connectionString = Connect();
        int num = 0;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO pt_office (pwalletID,admin_status,data_status,xcomment,xdoc1,xdoc2,xdoc3,xofficer,reg_date,xvisible) VALUES ('" + c_tm_office.pwalletID + "','" + c_tm_office.admin_status + "','" + c_tm_office.data_status + "','" + c_tm_office.xcomment + "','" + c_tm_office.xdoc1 + "','" + c_tm_office.xdoc2 + "','" + c_tm_office.xdoc3 + "','" + c_tm_office.xofficer + "','" + c_tm_office.reg_date + "','" + c_tm_office.xvisible + "') SELECT SCOPE_IDENTITY()";
        connection.Open();
        num = Convert.ToInt32(command.ExecuteScalar());
        if (num > 0)
        {
            SqlCommand command2 = connection.CreateCommand();
            command2.CommandText = "update pwallet set  status='" + c_tm_office.admin_status + "' ,data_status='" + c_tm_office.data_status + "' where ID='" + c_tm_office.pwalletID + "' ";
            num += command2.ExecuteNonQuery();
        }
        connection.Close();
        return num;
    }

    public List<PtInfo> getPtInfoSlipRS(string stage, string status)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT pt_info.*  FROM pt_info LEFT OUTER JOIN pwallet ON pt_info.log_staff=pwallet.ID LEFT OUTER JOIN pt_office ON pwallet.ID=pt_office.pwalletID  WHERE pt_office.admin_status = '" + stage + "' AND pt_office.data_status='" + status + "' AND pt_info.log_staff IN (Select pwallet.ID  FROM pwallet) ORDER BY pwallet.ID DESC", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public List<PtInfo> getPtInfoXRS(string stage, string status)
    {
        List<PtInfo> list = new List<PtInfo>();
        new PtInfo();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT pt_info.*  FROM pwallet LEFT OUTER JOIN pt_info ON pwallet.ID=pt_info.log_staff LEFT OUTER JOIN pt_office ON pt_office.pwalletID=pt_info.log_staff WHERE pwallet.status = '" + stage + "'  AND pt_office.data_status='" + status + "' AND pt_info.log_staff IN (Select pwallet.ID  FROM pwallet) ORDER BY pwallet.ID DESC", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtInfo item = new PtInfo
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

    public string getPtOfficeByMID(string pwalletID)
    {
        string str = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT data_status from pt_office where pwalletID='" + pwalletID + "'", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["data_status"].ToString();
        }
        reader.Close();
        return str;
    }

    public List<PtOffice> getPtOfficeDetailsByID(string ID)
    {
        List<PtOffice> list = new List<PtOffice>();
        new Pwallet();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pt_office WHERE pwalletID='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            PtOffice item = new PtOffice
            {
                ID = reader["ID"].ToString(),
                pwalletID = reader["pwalletID"].ToString(),
                admin_status = reader["admin_status"].ToString(),
                xcomment = reader["xcomment"].ToString(),
                xdoc1 = reader["xdoc1"].ToString(),
                xdoc2 = reader["xdoc2"].ToString(),
                xdoc3 = reader["xdoc3"].ToString(),
                xofficer = reader["xofficer"].ToString(),
                reg_date = reader["reg_date"].ToString(),
                xvisible = reader["xvisible"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;
    }

    public List<Pwallet> getPwalletDetailsByID(string ID)
    {
        List<Pwallet> list = new List<Pwallet>();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM pwallet WHERE ID='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            Pwallet item = new Pwallet
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

    public string getRoleByID(string id)
    {
        string str = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT xroleID from xadminz_pt where xID='" + id + "'", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["xroleID"].ToString();
        }
        reader.Close();
        return str;
    }


    public string getSurname(string id)
    {
        string str = "";
        SqlConnection connection = new SqlConnection(this.Connect2());
        SqlCommand command = new SqlCommand("SELECT surname from registrations where sys_ID='" + id + "'", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["surname"].ToString();
        }
        reader.Close();
        return str;
    }

    public string getRoleNameByID(string ID)
    {
        string str = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT name FROM roles WHERE priv='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["name"].ToString();
        }
        reader.Close();
        return str;
    }

    public List<Adminz> getTmAdminDetailsByID(string ID)
    {
        List<Adminz> list = new List<Adminz>();
        new Pwallet();
        SqlConnection connection = new SqlConnection(this.Connect());
        SqlCommand command = new SqlCommand("SELECT * FROM xadminz_pt WHERE xID='" + ID + "' ", connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            Adminz item = new Adminz
            {
                xID = reader["xID"].ToString(),
                xroleID = reader["xroleID"].ToString(),
                xname = reader["xname"].ToString(),
                xemail = reader["xemail"].ToString(),
                xpass = reader["xpass"].ToString(),
                xtelephone1 = reader["xtelephone1"].ToString(),
                xtelephone2 = reader["xtelephone2"].ToString(),
                xsection = reader["xsection"].ToString(),
                xlog_officer = reader["xlog_officer"].ToString(),
                xreg_date = reader["xreg_date"].ToString(),
                xvisible = reader["xvisible"].ToString()
            };
            list.Add(item);
        }
        reader.Close();
        return list;
    }

    public string getTotalEntries(string unit)
    {
        string str = "0";
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (unit != "")
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where status='" + unit + "'";
        }
        else
        {
            cmdText = "SELECT count(*) as count FROM pwallet ";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["count"].ToString();
        }
        reader.Close();
        return str;
    }

    public string getTotalEntriesByDate(string unit, string xfrom, string xto)
    {
        string str = "0";
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (unit != "")
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where (status='" + unit + "') AND (reg_date BETWEEN '" + xfrom + "' AND '" + xto + "') ";
        }
        else
        {
            cmdText = "SELECT count(*) as count FROM pwallet WHERE reg_date BETWEEN '" + xfrom + "' AND '" + xto + "' ";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["count"].ToString();
        }
        reader.Close();
        return str;
    }

    public string getTotalEntryCountByStage(string stage, string status)
    {
        string str = "0";
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (status == "")
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where status > '" + stage + "' ";
        }
        else
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where status='" + stage + "' AND data_status='" + status + "' ";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["count"].ToString();
        }
        reader.Close();
        return str;
    }

    public string getTotalEntryCountStageByDate(string stage, string status, string xfrom, string xto)
    {
        string str = "0";
        string cmdText = "";
        SqlConnection connection = new SqlConnection(this.Connect());
        if (status == "")
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where (status >'" + stage + "')  AND (reg_date BETWEEN '" + xfrom + "' AND '" + xto + "' ) ";
        }
        else
        {
            cmdText = "SELECT count(*) as count FROM pwallet  where (status='" + stage + "') AND (data_status='" + status + "') AND (reg_date BETWEEN '" + xfrom + "' AND '" + xto + "' ) ";
        }
        SqlCommand command = new SqlCommand(cmdText, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            str = reader["count"].ToString();
        }
        reader.Close();
        return str;
    }

    public class Adminz
    {
        public string xID;
        public string xemail;
        public string xlog_officer;
        public string xname;
        public string xpass;
        public string xreg_date;
        public string xroleID;
        public string xsection;
        public string xtelephone1;
        public string xtelephone2;
        public string xvisible;
    }

    //public class PtInfo
    //{
    //    public string xID;
    //    public string reg_number;
    //    public string xtype;
    //    public string title_of_invention;
    //    public string pt_class;
    //    public string spec_doc;
    //    public string loa_no;
    //    public string loa_doc;
    //    public string claim_no;
    //    public string claim_doc;
    //    public string pct_no;
    //    public string pct_doc;
    //    public string doa_no;
    //    public string doa_doc;
    //    public string log_staff;
    //    public string reg_date;
    //    public string xvisible;
    //}

    public class PtInfo
    {
        public string xID {get;set;}
        public string reg_number {get;set;}
        public string xtype {get;set;}
        public string title_of_invention {get;set;}
        public string pt_class { get; set; }
        public string loa_doc { get; set; }
        public string doa_doc { get; set; }
        public string ns_doc { get; set; }
        public string pd_doc { get; set; }
        public string rep_pic { get; set; }
        public string rep2_pic { get; set; }
        public string rep3_pic { get; set; }
        public string rep4_pic { get; set; }
        public string log_staff { get; set; }
        public string reg_date { get; set; }
        public string xvisible { get; set; }

        public string ApplicantId { get; set; }

        public string ApplicantName { get; set; }

        public string Office { get; set; }

        public string Sn { get; set; }

        public string Rdno { get; set; }
    }
    public class PtOffice
    {
        public string admin_status;
        public string data_status { get; set; }
        public string ID;
        public string pwalletID;
        public string reg_date;
        public string xcomment;
        public string xdoc1;
        public string xdoc2;
        public string xdoc3;
        public string xofficer;
        public string xvisible;
    }

    public class Pwallet
    {
        public string amt;
        public string applicantID;
        public string data_status;
        public string ID;
        public string reg_date;
        public string stage;
        public string status;
        public string validationID;
        public string visible;
    }

    public string formatDate(string date)
    {
        if ((date == "") || (date == null))
        {
            date = DateTime.Today.Date.ToString("MM/dd/yyyy");
        }
        string str3 = "";
        string str2 = date.Substring(0, 2);
        string str = date.Substring(3, 2);
        str3 = date.Substring(6, 4);
        return (str3 + "-" + str2 + "-" + str);
    }

    public string formatSearchDate(string date)
    {
        string str3 = "";
        string str2 = "";
        string str = "";
        string xstr = "";
        if (date != "")
        {
            str3 = "";
            str2 = date.Substring(0, 2);
            str = date.Substring(3, 2);
            str3 = date.Substring(6, 4);
            xstr = str3 + "-" + str2 + "-" + str;
        }
        return (xstr);

    }
}

