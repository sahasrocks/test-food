import axios from 'axios';
import React, { useEffect, useState } from 'react';

const YourForm = () => {
  const[data,setData]=useState([]);
  
  const [UserName, setUserName] = useState("");
  const [EmailId, setEmailId] = useState("");
  const [Password, setPassword] = useState("");
  const [Mobileno, setMobileno] = useState("");
  const [Address, setAddress] = useState("");
  const [UserType, setUserType] = useState("");
 
 
 

  // onst handleChange = (e) => {
  //   setFormData({ ...formData, [e.target.name]: e.target.value });
  // };c
  useEffect(() => {
    getData();
  }, []);

  const getData = () => {

    axios
      .get("http://localhost:5180/api/Users")
      .then((result) => {
        setData(result.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }
  const handleSubmit = () => {
    const url = "http://localhost:5180/api/Users";
    const data = {
      "UserName": UserName,
      "EmailId": EmailId,
      "Password": Password,
      "Mobileno": Mobileno,
      "Address": Address,
      "UserType": UserType
    };
    axios.post(url, data,{
      headers: {
        "Content-Type": "application/json",
      }})
      .then((result) => {
        getData();
        // cleanData();
      }).catch((error) => {
        console.log(error);
      })
  }

  
  return (
    <form>
      <label>
        UserName:
        <input type="text" name="UserName" value={UserName}
                onChange={(e) => setUserName(e.target.value)} />
      </label>
      <label>
        Password:
        <input type="text" name="Password" value={Password}
                onChange={(e) => setPassword(e.target.value)} />
      </label>
      <label>
        mobile no:
        <input type="text" name="Mobileno" value={Mobileno}
                onChange={(e) => setMobileno(e.target.value)} />

        {/* <input type="tel" name="MobileNo" value={formData.Mobileno} onChange={handleChange} /> */}
      </label>
      <label>
        emailid:
        <input type="email" name="EmailId" value={EmailId}
                onChange={(e) => setEmailId(e.target.value)}/>
      </label>
      <label>
        addess:
        <input type="text" name="Address" value={Address}
                onChange={(e) => setAddress(e.target.value)} />
      </label>
      <label>
        Usertype:
        <input type="text" name="UserType" value={UserType}
                onChange={(e) => setUserType(e.target.value)}/>
      </label>



      {/* Add other form fields as needed */}
      <button onClick={() => handleSubmit()} type="submit">Submit</button>
    </form>
  );
};

export default YourForm;
