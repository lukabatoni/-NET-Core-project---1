# 📌 Forum.ItAcademy.Ge  

## 🌍 Overview  
Forum.ItAcademy.Ge is a **web-based discussion platform** where users can:  
✅ Register and log in  
✅ Create new topics and participate in discussions  
✅ Write and delete comments  
✅ Edit, update, or delete personal information  
✅ Search for users by email and view their created topics  

The platform supports three roles:  
- 🛠 **Administrator** – Manages topics, users, and moderation.  
- 👤 **User** – Can create topics, comment, and edit profiles.  
- 👀 **Guest** – Can only view topics.  

---

## ⚙️ Features  

### 🔹 **User Role**  
- 📢 **News Feed** – Users see all topics with comment counts.  
- 🔎 **User Search** – Find users by email and view their topics.  
- ✏️ **Profile Management** – Edit personal details.  
- 📝 **Topic Creation** – Requires X comments on other topics before creating a new one.  
- 🚦 **Topic Approval** – Topics must be **approved by an admin** before appearing in the feed.  

### 🔹 **Administrator Role**  
- 📋 **Manage Topics** – Approve, hide, or delete topics.  
- 🛑 **Ban Users** – Temporarily restrict users with an automated unban system.  
- 🗂 **User Management** – View user lists and details.  

### 🔹 **Guest Role**  
- 👁 Can only view topics and comments (no interaction).  

---

## 🏗 Tech Stack  

🔹 **Backend:** ASP.NET Core (Web API + MVC + Background Worker)  
🔹 **Database:** SQL Server (EF Core, Code First Migrations)  
🔹 **Security:** JWT Authentication, ASP.NET Authorization  
🔹 **API Features:** API Versioning, Middleware, Global Exception Handling  
🔹 **Frontend:** Client-side & Server-side Validation  
🔹 **Utilities:** Fluent API, AutoMapper / Mapster  
🔹 **Testing:** Unit Testing (Application Layer Code Coverage)  
🔹 **DevOps:** Health Checks  

---

## 📂 Additional Features  
✅ **Auto-Archive** – Topics with no new comments for **X days** move to an archive.  
✅ **Image Uploads** – Users can attach images to topics.  
✅ **Pagination** – Optional (for future scalability).  

---

## 🚀 Installation  

### 1️⃣ Clone the Repository  
```sh
git clone https://github.com/your-username/Forum.ItAcademy.Ge.git
