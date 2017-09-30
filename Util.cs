using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AnsFinder
{
  class Util
  {

    private Keys[] KONAME_CMD = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Right, Keys.Left, Keys.Right, Keys.Left, Keys.B, Keys.A };



    /// <summary>
    /// アプリケーション実行パス取得
    /// </summary>
    /// <returns></returns>
    public String getAppPath()
    {
    
      return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
      //return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }


    public string[] getWordList(string str)
    {
      char[] delimiterChars = { ' ', '　'};

      string[] words = str.Split(delimiterChars);

      return words;
    }

    public Boolean isTextOnlySpace(string str) {

      Boolean result = false;
      string temp = str.Trim();

      if (temp.Length == 0)
      {
        result = true;
      }
      return result;
    }

    public Boolean chkKonamiCmd(Keys kc){

      Boolean result = false;


      return result;

    }

    public string escapeStr(string str) {

      string result = str;

      int singleQuote= str.IndexOf("'");
      int doubleQuote = str.IndexOf("\"");

      if( singleQuote >= 0 ){
        result = result.Insert(singleQuote, "'");
      }

      if (doubleQuote >= 0)
      {
        result = result.Insert(doubleQuote, "\"");
      }

      return result;
    }

  }
}
