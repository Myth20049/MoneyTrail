*{
  box-sizing: border-box;
}
body{
  background-color: #17181F;
  color: #ddd;
}
main{
  max-width: 360px;
  margin: 30px auto;
}
h1{
  text-align: center;
  color: #fff;
  margin:0;
  font-size: 2.5rem;
}
h1 span{
  font-size: 1rem;
  vertical-align: top;
  display: inline-block;
  margin-top: 6px;
}
form{
  margin-top: 20px;

}
form input{
  width: 100%;
  background-color: transparent;
  color: #ddd;
  padding: 2px 5px;
  border-radius: 5px;
  border: 2px solid #30313d;
}
form input[type="datetime-local"]{
  color: #777;
}
form button{
  width: 100%;
  margin-top: 5px;
  border: 0;
  border-radius: 5px;
  padding: 5px;
  background-color: #ddd;
}
form div.Basic{
  display: flex;
  gap: 5px;
  margin-bottom: 5px;
}
div.transactions{
  margin-top: 10px;

}
div.transaction{
  display: flex;
  padding: 5px 0;
  justify-content: space-between;
  border-top: 1px solid #30313d;
}
div.transaction:first-child{
  border-top: 0;
}
div.transaction div.name{
  font-size: 1rem;
}
div.transaction div.description{
  font-size: 0.7rem;
  color: #888;
}
div.right{
  text-align: right;
}
div.price.green{
  color: #1c1;
}
div.price.red{
  color: #c11;
}
