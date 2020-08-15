using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer;

namespace GUI_V_2
{
    class Cliente
    {
        private int idCliente;
        private string nomeCliente;
        private string cpf_Cliente;
        private string rg_Cliente;
        private string cnpj_Cliente;
        private string inscEst_Cliente;
        private string tel_Cliente;
        private string rua_Cliente;
        private string num_Cliente;
        private string bairro_Cliente;
        private string cep_Cliente;
        private string cidade_Cliente;
        private string email_Cliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome_Cliente { get => nomeCliente; set => nomeCliente = value; }
        public string CPF_Cliente { get => cpf_Cliente; set => cpf_Cliente = value; }
        public string RG_Cliente { get => rg_Cliente; set => rg_Cliente = value; }
        public string CNPJ_Cliente { get => cnpj_Cliente; set => cnpj_Cliente = value; }
        public string InscEst_Cliente { get => inscEst_Cliente; set => inscEst_Cliente = value; }
        public string Tel_Cliente { get => tel_Cliente; set => tel_Cliente = value; }
        public string Rua_Cliente { get => rua_Cliente; set => rua_Cliente = value; }
        public string Num_Cliente { get => num_Cliente; set => num_Cliente = value; }
        public string Bairro_Cliente { get => bairro_Cliente; set => bairro_Cliente = value; }
        public string CEP_Cliente { get => cep_Cliente; set => cep_Cliente = value; }
        public string Cidade_Cliente { get => cidade_Cliente; set => cidade_Cliente = value; }
        public string Email_Cliente { get => email_Cliente; set => email_Cliente = value; }

        SqlCommand com = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        public void Conectar()
        {
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=QuantConstruct;UID=sa;PWD=123";
            cn.Open();
        }

        public void IncluirCliente() //Incluir cliente Pessoa Física
        {
            Conectar();
            string sql = $"Insert into Cliente (IdCliente,Nome_Cliente,CPF_Cliente,RG_Cliente,CNPJ_Cliente,InscEst_Cliente,Tel_Cliente,Rua_Cliente,";
            sql += $"Num_Cliente,Bairro_Cliente,CEP_Cliente,Cidade_Cliente,Email_Cliente) values ('{IdCliente}','{Nome_Cliente}','{CPF_Cliente}','{RG_Cliente}',";
            sql += $"'{CNPJ_Cliente}','{InscEst_Cliente}','{Tel_Cliente}','{Rua_Cliente}','{Num_Cliente}','{Bairro_Cliente}','{CEP_Cliente}','{Cidade_Cliente}','{Email_Cliente}')";
            com.Connection = cn;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            cn.Close();
        }
        
        /*public void IncluirClientePJ() //Incluir cliente Pessoa Juridica
        {
            Conectar();
            string sql = $"Insert into Cliente (IdContato,Nome_Cliente,CNPJ_Cliente,InscEst_Cliente,Tel_Cliente,Rua_Cliente,";
            sql += $"Num_Cliente,Bairro_Cliente,CEP_Cliente,Cidade_Cliente,Email_Cliente) values ('{IdCliente}','{Nome_Cliente}',";
            sql += $"'{CNPJ_Cliente}','{InscEst_Cliente}','{Tel_Cliente}','{Rua_Cliente}','{Num_Cliente}','{Bairro_Cliente}','{CEP_Cliente}','{Cidade_Cliente}','{Email_Cliente}')";
            com.Connection = cn;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            cn.Close();
        }*/

        public void AlterarCliente()
        {
            Conectar();
            string sql = $"Update Cliente set Nome_Cliente = '{Nome_Cliente}',CPF_Cliente = '{CPF_Cliente}',RG_Cliente = '{RG_Cliente}',";
            sql += $"CNPJ_Cliente = '{CNPJ_Cliente}',InscEst_Cliente = '{InscEst_Cliente}',Tel_Cliente = '{Tel_Cliente}',Rua_Cliente = '{Rua_Cliente}',Num_Cliente = '{Num_Cliente}',";
            sql += $"Bairro_Cliente = '{Bairro_Cliente}',CEP_Cliente = '{CEP_Cliente}',Cidade_Cliente = '{Cidade_Cliente}',Email_Cliente = '{Email_Cliente}'";
            sql += $" where IdCliente = {IdCliente}";
            com.Connection = cn;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            cn.Close();
        }

        /*public void AlteralClientePJ()
        {
            Conectar();
            string sql = $"Update Cliente set Nome_Cliente = '{Nome_Cliente}',CNPJ_Cliente = '{CNPJ_Cliente}',";
            sql += $"InscEst_Cliente = '{InscEst_Cliente}',Tel_Cliente = '{Tel_Cliente}',Rua_Cliente = '{Rua_Cliente}',Num_Cliente = '{Num_Cliente}',";
            sql += $"Bairro_Cliente = '{Bairro_Cliente}',CEP_Cliente = '{CEP_Cliente}',Cidade_Cliente = '{Cidade_Cliente}',Email_Cliente = '{Email_Cliente}'";
            sql += $" where IdCliente = {IdCliente}";
            com.Connection = cn;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            cn.Close();
        }*/

        public void ExcluirCliente()
        {
            Conectar();
            string sql = $"Delete from Cliente where IdCliente = {IdCliente}";
            com.Connection = cn;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void ConsultarCliente()
        {
            Conectar();
            string sql = $"Select * from Cliente where IdCliente = {IdCliente}";
            com.Connection = cn;
            com.CommandText = sql;
            SqlDataReader DataReader = com.ExecuteReader();
            if (DataReader.Read())
            {
                Nome_Cliente = DataReader["Nome_Cliente"].ToString();
                CPF_Cliente = DataReader["CPF_Cliente"].ToString();
                RG_Cliente = DataReader["RG_Cliente"].ToString();
                CNPJ_Cliente = DataReader["CNPJ_Cliente"].ToString();
                InscEst_Cliente = DataReader["InscEst_Cliente"].ToString();
                Tel_Cliente = DataReader["Tel_Cliente"].ToString();
                Rua_Cliente = DataReader["Rua_Cliente"].ToString();
                Num_Cliente = DataReader["Num_Cliente"].ToString();
                Bairro_Cliente = DataReader["Bairro_Cliente"].ToString();
                CEP_Cliente = DataReader["CEP_Cliente"].ToString();
                Cidade_Cliente = DataReader["Cidade_Cliente"].ToString();
                Email_Cliente = DataReader["Email_Cliente"].ToString();
            }
            cn.Close();
        }

        public int ConsultarID()
        {
            Conectar();
            string sql = $"Select MAX(IdCliente) from Cliente";
            com.Connection = cn;
            com.CommandText = sql;
            int Id = (int)com.ExecuteScalar();
            cn.Close();
            return Id;
        }

    }
}