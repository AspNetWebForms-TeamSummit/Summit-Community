# Summit Community

## The Web App that brings together different communities.

The application consists of discussion forums on user chosen topics, arranged under different categories.
The topic can be set by a question or a discussion statement and answers/opinions. 
Each question and each answer can be upvoted or downvoted.

###Types of users

1. Admins: they can add categories; delete content
2. Registered users: They can post new topics and answer existing ones
3. Visitors /without login/: they can only read all topica vailable

There is also a page with statistics such as: the most discussed topic; the most upvoted/downvoted answer/question...

Registered users can propose new categories???

###Web forms

- Login 
- Register 
- Home  
- Categories 
-  Topics for the category clicked
-   Question & Answers for each topic
- Statistics
- User Profile 

###Database

Entities:
- Users(Id, username/email, role, password)
- Categories(Id, name)
- Questions/Topics(Id, name, content, categoryId, userid, vote)
- Answers(Id, content, queastionId, userId, vote)

Relations:
- Users to Questions: 1 to many
- Users to Answers: 1 to many
- Categories to Questions: 1 to many
- Questions to Answers: 1 to many







