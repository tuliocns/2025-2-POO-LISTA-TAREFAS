public class Operacoes
{
    private string connectionString = "";
    public int Criar(Tarefa tarefa)
    {
        using(var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao)
                            VALUES (@nome, @descricao, @dataCriacao, @status, @dataExecucao);
                            SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("dataDescricao", tarefa.NdataDescricao);
                cmd.Parameters.AddWithValue("status", tarefa.status;
                cmd.Parameters.AddWithValue("dataExecucao", tarefa.dataExecucao);

                return convert.ToInt32(cmd.ExecuteScalar());
            
            }
        }
        return 0;
    }

    public Tarefa Buscar(int id)
    {
        return null;
    }

    public List<Tarefa> Listar()
    {
        return Array.Empty<Tarefa>();
    }

    public void Alterar(Tarefa tarefa)
    {
    
    }

    public void Excluir(int id)
    {

    }
}