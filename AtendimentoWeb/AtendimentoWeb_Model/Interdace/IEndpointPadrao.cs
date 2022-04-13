using System.Collections.Generic;

namespace AtendimentoWeb_Model.Interdace
{
    public interface IEndpointPadrao<T>
    {
        public T Get(long? id = null);

        public List<string> GetList();

        public string Post();

        public void Put(long id, string value);

        public void Delete(long id);

        public void Path(long id, string value);
    }
}
