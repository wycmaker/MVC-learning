using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MessageBoard.Models;

namespace MessageBoard.Services
{
    public class MessageDBService
    {
        MessageEntities db = new MessageEntities();
        public List<Message> GetMessages()
        {
            List<Message> DataList = db.Message.ToList();
            db.Dispose();
            return DataList;
        }

        public void CreateMessage(Message data)
        {
            data.Create_Time = DateTime.Now;
            db.Message.Add(data);
            db.SaveChanges();
            db.Dispose();
        }

        public Message FindMessage(int id)
        {
            Message data = db.Message.Find(id);
            db.Dispose();
            return data;
        }

        public void EditMessage(Message NewData)
        {
            Message Data = db.Message.Find(NewData.Id);
            Data.Content = NewData.Content;
            Data.Create_Time = DateTime.Now;
            db.SaveChanges();
            db.Dispose();
        }

        public void DeleteMessage(int id)
        {
            Message data = db.Message.Find(id);
            db.Message.Remove(data);
            db.SaveChanges();
            db.Dispose();
        }
    }
}