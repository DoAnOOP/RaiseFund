using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class UserController : Controller
    {
        // GET: User


        public DatabaseDataContext db = new DatabaseDataContext();


        public ActionResult Index()
        {
            return View();
        }

        public string Add_prd()
        {
            string URL = Request["p-image"];
            string title = Request["p-title"];
            string bank = Request["p-bank"];
            string desc = Request["p-desc"];
            string category = Request["p-category"];
            string goal = Request["p-goal"];
            string ownerId = Request["p-owner"];
            string ownerFullname = Request["p-fullname"];

            if (!string.IsNullOrEmpty(URL) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(bank) && !string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(goal))
            {
                try
                {
                    //trường hợp muốn insert
                    Campaign cpn = new Campaign();
                    cpn.Bank_Name = bank;
                    cpn.Campaign_Img = URL;
                    cpn.Campaign_Title = title;
                    cpn.Campaign_Goal = int.Parse(goal);
                    cpn.Campaign_Cate = category;
                    cpn.Campaign_Owner = ownerId;
                    cpn.Campaign_Story = desc;
                    cpn.Campaign_FullName = ownerFullname;
                    db.Campaigns.InsertOnSubmit(cpn);
                    db.SubmitChanges();

                    return "Thêm mới campaign thành công";
                }
                catch (Exception ex)
                {
                    return "Thêm mới campaign thất bại. Chi tiết lỗi: " + ex.Message;
                }
            }
            else
            {
                return "Bạn Chưa Nhập Đủ Dữ Liệu";
            }
        }

        public string Edit_prd()
        {
            string id = Request["productID"];
            string URL = Request["p-image"];
            string title = Request["p-title"];
            string bank = Request["p-bank"];
            string desc = Request["p-desc"];
            string category = Request["p-category"];
            string goal = Request["p-goal"];
            string ownerId = Request["p-owner"];
            string ownerFullname = Request["p-fullname"];

            if (!string.IsNullOrEmpty(URL) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(bank) && !string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(goal) && !string.IsNullOrEmpty(id))
            {
                try
                {
                    var qrs = db.Campaigns.Where(o => o.Campaign_ID == int.Parse(id));
                    if (qrs.Any())
                    {
                        //có trả về bản ghi.
                        Campaign cpn = qrs.SingleOrDefault();
                        cpn.Bank_Name = bank;
                        cpn.Campaign_Img = URL;
                        cpn.Campaign_Title = title;
                        cpn.Campaign_Goal = int.Parse(goal);
                        cpn.Campaign_Cate = category;
                        cpn.Campaign_Owner = ownerId;
                        cpn.Campaign_Story = desc;
                        cpn.Campaign_FullName = ownerFullname;
                        db.SubmitChanges();

                        return "Cập nhật thông tin campaign thành công";
                    }
                    else
                    {
                        return "Khong tim thay cpn";
                    }
                }
                catch (Exception ex)
                {
                    return "Thêm mới sản phẩm thất bại. Chi tiết lỗi: " + ex.Message;
                }
            }
            else
            {
                return "Bạn Chưa Nhập Đủ Dữ Liệu";
            }
        }

        public string get_All()
        {
            APIResult_ett<List<Campaign>> rs = new APIResult_ett<List<Campaign>>();
            try
            {
                //truy vấn db để lấy toàn bộ dữ liệu về ds sản phẩm
                var qr = db.Campaigns.Where(o => o.Campaign_Owner != null);
                if (qr.Any())
                {
                    //có dữ liệu => chính là dssv
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Lấy DS Campaign thành công";
                    rs.Data = qr.ToList();
                }
                else
                {
                    //không có dữ liệu thỏa mãn
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "DS Campaign rỗng";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình lấy về DSSP. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return JsonConvert.SerializeObject(rs);
        }

        public string get_SP_Info()
        {
            string productID = Request["productID"];
            try
            {
                var qr = db.Campaigns.Where(o => o.Campaign_ID == int.Parse(productID));
                if (qr.Any())
                {
                    var sp_obj = qr.SingleOrDefault();

                    return JsonConvert.SerializeObject(sp_obj);
                }
                else
                {
                    return "Không tìm thấy Campaign có ID=" + productID;
                }

            }
            catch (Exception ex)
            {
                return "Lấy thông tin Campaign thất bại. Chi tiết lỗi: " + ex.Message;
            }
        }

        public string get_CampaignID_Campaign_Owner()
        {

            APIResult_ett<List<Campaign>> rs = new APIResult_ett<List<Campaign>>();
            string ownerId = Request["p-owner"];
            string ownerFullname = Request["p-fullname"];
            try
            {
                //truy vấn db để lấy toàn bộ dữ liệu về ds sản phẩm
                var qr = db.Campaigns.Where(o => o.Campaign_Owner == ownerId && o.Campaign_FullName == ownerFullname);
                if (qr.Any())
                {
                    //có dữ liệu => chính là dssv
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Lấy DS Campaign thành công";
                    rs.Data = qr.ToList();
                }
                else
                {
                    //không có dữ liệu thỏa mãn
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "DS Campaign rỗng";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình lấy về DSSP. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return JsonConvert.SerializeObject(rs);
        }

        public string Add_Comment()
        {

            string ownerId = Request["p-owner"];

            string productID = Request["productID"];

            string comment = Request["comment"];

            string ownerFullname = Request["p-fullname"];

            if (!string.IsNullOrEmpty(ownerId) && !string.IsNullOrEmpty(productID) && !string.IsNullOrEmpty(comment) && !string.IsNullOrEmpty(ownerFullname))
            {
                try
                {
                    //trường hợp muốn insert
                    Comment cmt = new Comment();
                    cmt.Account_ID = Convert.ToInt32(ownerId);
                    cmt.Campaign_ID = Convert.ToInt32(productID);
                    cmt.Comment_Content = comment;
                    cmt.Campaign_FullName = ownerFullname;

                    db.Comments.InsertOnSubmit(cmt);
                    db.SubmitChanges();

                    return "Thêm mới comment thành công mời reset lại trang";
                }
                catch (Exception ex)
                {
                    return "Thêm mới comment thất bại. Chi tiết lỗi: " + ex.Message;
                }
            }
            else
            {
                return "Bạn Chưa Nhập Đủ Dữ Liệu";
            }
        }

        public string get_Comment()
        {
            APIResult_ett<List<Comment>> rs = new APIResult_ett<List<Comment>>();
            string campaign_ID = Request["campaign_ID"];
            Console.WriteLine(campaign_ID);

            {
                //truy vấn db để lấy toàn bộ dữ liệu về ds sản phẩm
                var qr = db.Comments.Where(o => o.Campaign_ID == Convert.ToInt32(campaign_ID));

                if (qr != null)
                {
                    //có dữ liệu => chính là dssv
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Lấy DS Comment thành công";
                    rs.Data = qr.ToList();
                }
                else if (qr == null)
                {
                    //không có dữ liệu thỏa mãn
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "DS Comment rỗng";
                    rs.Data = null;
                }
            }


            return JsonConvert.SerializeObject(rs);
        }
    }
}
