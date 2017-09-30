using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnsFinder.Data
{
  class Quiz
  {
    /// <summary>
    /// id
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 色数
    /// </summary>
    public int colurs { get; set; }
    /// <summary>
    /// ジャンル
    /// </summary>
    public int genre { get; set; }
    /// <summary>
    /// 問題文
    /// </summary>
    public string question { get; set; }
    /// <summary>
    /// 選択肢1（答え）
    /// </summary>
    public string ans1 { get; set; }
    /// <summary>
    /// 選択肢2
    /// </summary>
    public string ans2 { get; set; }
    /// <summary>
    /// 選択3
    /// </summary>
    public string ans3 { get; set; }
    /// <summary>
    /// 選択4
    /// </summary>
    public string ans4 { get; set; }
  }
}
