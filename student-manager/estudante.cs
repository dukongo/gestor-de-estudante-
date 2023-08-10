using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_manager
{
    internal class estudante
    {
        MEU_BD meubancoDeDados = new MEU_BD();

        public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco,
            MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nm,@snm,@nsc,@gen,@tel,@end,@ft) ", meubancoDeDados.getConexao);

            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
           
            comando.Parameters.Add("@end", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@ft", MySqlDbType.LongBlob).Value = foto.ToArray();

            meubancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meubancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meubancoDeDados.fecharConexao();
                return false;
            }




            
            


            return false;
        }

    }
}
