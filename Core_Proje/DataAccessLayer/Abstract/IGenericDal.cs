using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class
    {
        // where ile koştuğumuz şart t değeri bir classa ait tüm değerleri alabilir
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID (int id);
    }
}
