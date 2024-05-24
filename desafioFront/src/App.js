import React, { useEffect, useState } from 'react';
import axios from 'axios';
import './App.css';

function App() {
  const [users, setUsers] = useState();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  async function GetUsers() {
    try{
      await axios.get('http://localhost:5214/api/Users')
      .then(response => {
        setUsers(response.data)
      })
    }
    catch(error){
      alert('ERRO: ' + error)
    }
  }

  useEffect(() => {
    GetUsers();
  }, []);

  return (
    <div className="App">
      <div className='Container-geral'>
        <p className='Titulo-pagina'>Relatório de usuários</p>

        <table>
          <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Age</th>
                <th>Gender</th>
                <th>Location</th>
                <th>Country</th>
                <th>Phone</th>
                <th>Cell-phone</th>
            </tr>
          </thead>
          <tbody>
              {
                users?.map(item => (
                  <tr>
                    <td key={item.email}>{item.firstname} {item.lastname}</td>
                    <td key={item.email}>{item.email}</td>
                    <td key={item.email}>{item.age}</td>
                    <td key={item.email}>{item.gender}</td>
                    <td key={item.email}>{item.city}, {item.statelocation}</td>
                    <td key={item.email}>{item.country}</td>
                    <td key={item.email}>{item.phone}</td>
                    <td key={item.email}>{item.cell}</td>
                  </tr>
                ))
              }
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default App;
