using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //İs kodları yazılır. Eger sartlar saglanıyor ise DataAccesteki GetAll metodu calısır.

            return _carDal.GetAll();        

        }
    }
}
