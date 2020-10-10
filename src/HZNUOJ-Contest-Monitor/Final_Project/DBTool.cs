using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class DBTool
    {
        public static string server = "";
        public static string user_id = "";
        public static string password = "";
        public static string contest_id = "";
        public static string sql;
        public static DataSet ds;
        
        public static string getConnectionString()
        {
            return "server=" + server + ";user id=" + user_id + ";password=" + password + ";database=jol;charset=utf8";
        }

        //连接测试
        public static bool LogInTest()
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                try
                {
                    connection.Open(); 
                }
                catch (Exception ex) 
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            return true; 
        }

        //查询
        public static DataSet Query(string SQLString)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySqlDataAdapter command = new MySqlDataAdapter(SQLString, connection);
                    command.Fill(ds);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return ds;
            }
        }

        //执行
        public static int ExecuteSql(string SQLString)
        {
            using (MySqlConnection connection = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        connection.Close();
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        connection.Close();
                    }
                }
            }
        }

        public static int getTotAC()
        {
            sql = "SELECT count(solution_id) FROM solution WHERE result = 4 AND contest_id = " + contest_id;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        public static int getTotSubmit() 
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //0 pending
        //1 pending and rejudge
        //2 Compiling
        //3 Running and Judging
        //4 Accepted
        //5	Presentation Error
        //6 Wrong Answer
        //7 Time Limit Exceed
        //8 Memory Limit Exceed
        //9 Output Limit Exceed
        //10 Runtime Error
        //11 Compile Error

        //通过num获取DISTINCT_AC数量
        public static int getDISTINCTACByNum(int num)
        {
            sql = "SELECT count(DISTINCT user_id) FROM solution WHERE contest_id = " + contest_id + " AND num = " + num;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过num获取提交总量
        public static int getTotSubmitByNum(int num)
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id + " AND num = " + num;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过result获取结果数量
        public static int getTotResult(int result)
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id + " AND result = " + result;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过result和num获取结果数量
        public static int getTotResultByResultAndNum(int result, int num)
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id + " AND result = " + result + " AND num = " + num;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }

        }

        //0 13 C
        //1 14 C++
        //3 Java
        //6 18 Python

        //通过语言类型获取结果数量
        public static int getTotResultBylanguage(int language)
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id + " AND language = " + language;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过语言类型及题号获取结果数量
        public static int getTotResultBylanguageAndNum(int language, int num) 
        {
            sql = "SELECT count(solution_id) FROM solution WHERE contest_id = " + contest_id + " AND language = " + language + " AND num = " + num;
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //获取该场contest参与人数
        public static int getPopulation()
        {
            sql = "SELECT count(DISTINCT user_id) as num FROM solution WHERE contest_id = " + DBTool.contest_id;
            try
            {
                ds = Query(sql);
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message); 
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //获取Hit次数
        public static int getHitByTime(string date)
        {
            sql = "SELECT count(ip) FROM hit_log WHERE time >= DATE('" + OperateForm.launch_time + "')";
            try
            {
                ds = Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //获取当前时间
        public static string getNow()
        {
            sql = "SELECT NOW()";
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        //获取contest开始时间
        public static string getStartTime()
        {
            sql = "SELECT start_time FROM contest WHERE contest_id = " + DBTool.contest_id;
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }
        
        //获取contest结束时间
        public static string getEndTime()
        {
            sql = "SELECT end_time FROM contest WHERE contest_id = " + DBTool.contest_id;
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        //获取题数
        public static int getProblemCnt()
        {
            sql = "SELECT max(num) as Num FROM contest_problem WHERE contest_id = " + DBTool.contest_id;
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //获取首A时间
        public static string getFirstSolveTime(int num)
        {
            sql = "SELECT count(in_date) as num, min(in_date) " +
                      "FROM solution " +
                      "WHERE result = 4 " +
                      "AND contest_id = " + contest_id + " " +
                      "AND num = " + num;
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) > 0)
            {
                return ds.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                return null;
            }
        }

        //获取过题队伍数
        public static int getProblemTeamByCnt(int cnt)
        {
            sql = "" +
                "SELECT C.num FROM(" + " " +
                    "SELECT B.cnt, count(B.cnt) as num FROM(" + " " +
                        "SELECT user_id, count(A.num) as cnt FROM(" + " " +
                            "SELECT user_id, num, min(in_date) FROM solution" + " " +
                            "WHERE contest_id = " + DBTool.contest_id + " " +
                            "AND result = '4'" + " " +
                            "GROUP BY user_id, num" + " " +
                            "ORDER BY user_id" + " " +
                        ") AS A GROUP BY A.user_id" + " " +
                ") AS B GROUP BY B.cnt ) AS C WHERE C.cnt = " + cnt;
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过开始时间、结束时间、结果获取提交数
        public static int getTotSubmitByStEdAndResult(string st, string ed, int result)
        {
            sql = "" +
                "SELECT count(solution_id) as cnt FROM solution " +
                "WHERE contest_id = " + DBTool.contest_id + " " +
                " AND result = " + result +
                " AND UNIX_TIMESTAMP(in_date) >= UNIX_TIMESTAMP('" + st + "')" +
                " AND UNIX_TIMESTAMP(in_date) <= UNIX_TIMESTAMP('" + ed + "')";
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过开始时间、结束时间、结果获取总提交数
        public static int getTotSubmitByStEd(string st, string ed)
        {
            sql = "" +
                "SELECT count(solution_id) as cnt FROM solution " +
                "WHERE contest_id = " + DBTool.contest_id + " " +
                " AND UNIX_TIMESTAMP(in_date) >= UNIX_TIMESTAMP('" + st + "')" +
                " AND UNIX_TIMESTAMP(in_date) <= UNIX_TIMESTAMP('" + ed + "')";
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过开始时间、结束时间、结果获取提交数
        public static int getTotSubmitByStEdAndResultAndNum(string st, string ed, int result, int num)
        {
            sql = "" +
                "SELECT count(solution_id) as cnt FROM solution " +
                "WHERE contest_id = " + DBTool.contest_id + " " +
                " AND result = " + result +
                " AND num = " + num + 
                " AND UNIX_TIMESTAMP(in_date) >= UNIX_TIMESTAMP('" + st + "')" +
                " AND UNIX_TIMESTAMP(in_date) <= UNIX_TIMESTAMP('" + ed + "')";
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        //通过开始时间、结束时间、结果获取总提交数
        public static int getTotSubmitByStEdAndNum(string st, string ed, int num)
        {
            sql = "" +
                "SELECT count(solution_id) as cnt FROM solution " +
                "WHERE contest_id = " + DBTool.contest_id + " " +
                "AND num = " + num + 
                " AND UNIX_TIMESTAMP(in_date) >= UNIX_TIMESTAMP('" + st + "')" +
                " AND UNIX_TIMESTAMP(in_date) <= UNIX_TIMESTAMP('" + ed + "')";
            try
            {
                ds = DBTool.Query(sql);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                return 0;
            }
        }

    }
}
