using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// DataSetに値を格納するクラス
    /// </summary>
    class DataStorage
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        //コンストラクタ
        public DataStorage()
        {
            // 列追加します。
            dt.Columns.Add("textname");
            dt.Columns.Add("ID");

            // 行追加します。
            dt.Rows.Add();

            //列と行をDataSetに追加
            ds.Tables.Add(dt);
        }

        string tvalue = null;
        int tkey = 0;
        //DataSetに行を追加し、登録するメソッド
        public void datainsert(IDictionary<int, string> data)
        {

            foreach (KeyValuePair<int, string> item in data)
            {
                tkey = item.Key;

                tvalue = item.Value;
            }
            
            //行を追加
            DataRow row = ds.Tables[0].NewRow();
            //値を格納
            row["ID"] = tkey;
            row["textname"] = tvalue;
            
            //DataSetに追加
            ds.Tables[0].Rows.Add(row);

            var xmlmanager = new XmlManager();
            StreamWriter sr = xmlmanager.XmlCreateFile();

            ds.WriteXml(sr);
            sr.Close();
        }


        //DataSet削除メソッド
        public void datadeleate()
        {

        }
    }
}
