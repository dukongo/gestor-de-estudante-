﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace student_manager
{
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=t5_sga_bd");

        public MySqlConnection getConexao
        {
            get 
            { 
                return conexao; 
            }
        }
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
    
}

