using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnsFinder
{
  public partial class Form1 : Form
  {

    private string dbFile = "ansfinder.db";
    private string dbName = "QUIZ";

    string appPath = "";
    string dbPath = "";

    Util util = new Util();

    public Form1()
    {
      InitializeComponent();

      colours_CB.SelectedIndex = 0;
      genre_CB.SelectedIndex = 0;
      this.appPath = util.getAppPath();
      this.dbPath = @"DataSource=" + appPath + "\\db\\" + dbFile;
    }

    /// <summary>
    /// 検索ボタン押下
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void search_B_Click(object sender, EventArgs e)
    {
      search();
    }

    private void search_TB_KeyUp(object sender, KeyEventArgs e)
    {
      search();
    }

    /// <summary>
    /// 検索処理
    /// </summary>
    private void search(){

      if (search_TB.Text.Length > 0 && !util.isTextOnlySpace(search_TB.Text))
      {
        string searchWord = search_TB.Text;
        int colours = colours_CB.SelectedIndex;
        int genre = genre_CB.SelectedIndex;

        SQLiteConnection hConnection = new SQLiteConnection(dbPath);
        string selectQuery = createSQL();

        SQLiteCommand myCommand = new SQLiteCommand(selectQuery, hConnection);
        hConnection.Open();
        SQLiteDataReader myReader = null;

        StringBuilder sb = new StringBuilder();
        result_RTB.Text = "";

        try
        {
          myReader = myCommand.ExecuteReader();

          sb.Append(@"{\rtf1\ansi\ansicpg932");

          while (myReader.Read())
          {
            string question = myReader.GetString(3);
            //string tempQ = myReader["question"].ToString();

            string answer = myReader.GetString(4);

            sb.Append(@"+++++++++++++++++++++++++++++++++++++++++++ \line ");
            sb.Append(@"問題：　\line ");
            sb.Append(question);
            sb.Append(@" \line \line ");
            sb.Append(@"答え：　\fs30 \b ");
            sb.Append(answer);
            sb.Append(@" \b0 \fs18 \line ");
          }
        }
        catch (Exception ex)
        {
          Console.Write(MessageBox.Show(ex.ToString()));
        }
        finally
        {
          if (myReader != null)
          {
            myReader.Close();
          }
          if (hConnection != null)
          {
            hConnection.Close();
            hConnection.Dispose();
          }
        }
        sb.Append("}");

        result_RTB.Rtf = sb.ToString();
      }
      else {
        result_RTB.Text = "";
      }
    }

    /// <summary>
    /// SQL文作成
    /// </summary>
    /// <returns></returns>
    private string createSQL()
    {
      string result = "SELECT * FROM " + dbName + " ";
      string where = "WHERE ";
      Boolean apndedFlg = false;

      if (colours_CB.SelectedIndex != 0)
      {
        where += "COLOURS = " + colours_CB.SelectedIndex;
        apndedFlg = true;
      }

      if (genre_CB.SelectedIndex != 0)
      {
        if (apndedFlg)
        {
          where += " AND GENRE = " + genre_CB.SelectedIndex;
        }
      }
      
      string[] words = util.getWordList(search_TB.Text);

      foreach (string token in words)
      {
        if (!token.Equals("") )
        {

          string escToken = util.escapeStr(token);
          Console.WriteLine(escToken);

          if (apndedFlg)
          {
            where += " AND QUESTION LIKE '%" + escToken + "%'";
          }
          else
          {
            where += "QUESTION LIKE '%" + escToken + "%'";
            apndedFlg = true;
          }
        }
      }

      if(apndedFlg){
        result += where;
      }
      return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clearB_Click(object sender, EventArgs e)
    {
      colours_CB.SelectedIndex = 0;
      genre_CB.SelectedIndex = 0;
      search_TB.Text = "";
      result_RTB.Text = "";
    }
  }
}
