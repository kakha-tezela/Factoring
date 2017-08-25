using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using FactoringService.Core.Domain;
using FactoringService.Persistence;
using AutoMapper;

namespace FactoringService
{
    public class Service1 : IService1
    {
        public string GetData()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Source, Destination>();
            });
            IMapper mapper = config.CreateMapper();


            var source = new Source();
            source.Firstname = "Olega";
            source.Lastname = "Iadze";
            source.ListOfOnes = new List<One>
            {
                new One { Age = "20", Name = "Bidzina bratashvili"},
                new One { Age = "50", Name = "Gogia Shalamberidze"}
            };

            var result = mapper.Map<Destination>(source);

            return "ok";
        }
    }


    public class Source
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IEnumerable<One> ListOfOnes { get; set; }
    }


    public class Destination
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<One> ListOfOnes { get; set; }
    }

    public class One
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

}









//var config = new MapperConfiguration(cfg => {
//    cfg.CreateMap<Source, Destination>()
//    .ForMember(
//        dest => dest.One,
//        opt => opt.MapFrom( src => string.Format("{0} {1}", src.one.Firstname, src.one.Lastname )));
//});
//IMapper mapper = config.CreateMapper();

//var source = new Source();
//source.Firstname = "Xevisberi";
//source.Lastname = "Gocha";
//source.one = new One { Firstname = "Lado", Lastname = "Gelashvili" };

//var result = mapper.Map<Source, Destination>(source);