# Skill-Demo-in-2022
A project which prove that I still have some programming skills in 2022

##  這是什麼  

前端是一個靜態網頁   
會架在[licalica.com](http:/licalica.com)  

是用AWS的route53做DNS服務而內容存在s3 bucket 

後端則是一個自己製作後端常用CRUD範例，  
使用Web API2的範例遵從Rsetful標準與MSSQL連線  
改寫成一個簡單的人名與臉書記錄系統

建置後可以藉由  

Get  

https://localhost:44312/api/Values
來取得所有清單  


https://localhost:44312/api/Values?serno={serno}   
來取得特定序號的URL   

POST   
https://localhost:44312/api/Values  
且在Body  

{
  "SerNo": "不填會依照順序產生序號",
  "Name": "人名",
  "FBUrl": “網址列"
}

來做資料新增與修改  
並使用  

DELETE  
https://localhost:44312/api/Values?serno={serno}  
來刪除特定序號的資料  

主要是希望藉由這個專案讓教授或其他看到的人  
大概能瞭解我在2022的程式能力  

這個專案希望可以達到這三點  
#### 1.易理解的


#### 2.可展示的


#### 3.有價值的  



最後再順便複習寫.md檔案以及單純使用終端操作git推到github上，   
以及解除版本衝突