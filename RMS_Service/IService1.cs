using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace RMS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(InsertOrder order);

        [OperationContract]
        getdata GetOI();

        [OperationContract]
        string Update(UpdateOI o);

        [OperationContract]
        string Delete(DeleteOI d);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class DeleteOI {
        int o_id;

        [DataMember]
        public int O_ID {
            get { return o_id; }
            set { o_id = value; }
        }

    }

    [DataContract]
    public class UpdateOI {
        int o_id;
        string o_name;
        string o_desc;
        string o_price;
        string o_type;
        string o_stat;
        string o_cate;

        [DataMember]
        public int O_ID {
            get { return o_id; }
            set { o_id = value; }
        }

        [DataMember]
        public string O_Name
        {
            get { return o_name; }
            set { o_name = value; }
        }

        [DataMember]
        public string O_Desc
        {
            get { return o_desc; }
            set { o_desc = value; }
        }

        [DataMember]
        public string O_Price
        {
            get { return o_price; }
            set { o_price = value; }
        }

        [DataMember]
        public string O_Type
        {
            get { return o_type; }
            set { o_type = value; }
        }

        [DataMember]
        public string O_Stat
        {
            get { return o_stat; }
            set { o_stat = value; }
        }

        [DataMember]
        public string O_Cate
        {
            get { return o_cate; }
            set { o_cate = value; }
        }
    }



    [DataContract]
    public class getdata {
        [DataMember]
        public DataTable Res_Tab {
            get;
            set;
        }
    }
    
    
    [DataContract]
    public class InsertOrder
    {
        string o_name = string.Empty;
        string o_desc = string.Empty;
        string o_price = string.Empty;
        string o_type = string.Empty;
        string o_stat = string.Empty;
        string o_cate = string.Empty;

        [DataMember]
        public string O_Name
        {
            get { return o_name; }
            set { o_name = value; }
        }

        [DataMember]
        public string O_Desc
        {
            get { return o_desc; }
            set { o_desc = value; }
        }

        [DataMember]
        public string O_Price
        {
            get { return o_price; }
            set { o_price = value; }
        }

        [DataMember]
        public string O_Type
        {
            get { return o_type; }
            set { o_type = value; }
        }

        [DataMember]
        public string O_Stat
        {
            get { return o_stat; }
            set { o_stat = value; }
        }

        [DataMember]
        public string O_Cate
        {
            get { return o_cate; }
            set { o_cate = value; }
        }
    }
}
