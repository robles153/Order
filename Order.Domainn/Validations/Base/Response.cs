using System.Collections.Generic;

namespace Order.Domain.Validations.Base
{
    public class Response
    {
        public Response()
        {
            Reports = new List<Report>();
        }

        public Response(List<Report> reports)
        {
            Reports = reports;
        }

        public Response(Report report) : this(new List<Report>() { report})
        {

        }

        public List<Report> Reports { get; }
    }

    public class Response<T> : Response
    {
        public Response()
        {

        }

        public Response(T data, List<Report> reports = null) : base(reports)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
