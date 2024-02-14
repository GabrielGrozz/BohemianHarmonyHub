import { useState } from "react";
import "./App.css";
import Band from "./Components/Band";
import axios from "axios";

function App() {
  const [data, setData] = useState([]);

  const url = "https://localhost:7117/Bands";

  const req = () =>
    axios.get(url).then((res) => {
      setData(res.data);
      return console.log(res.data);
    });

  function atualiza() {
    setDataa(dataa + 1);
  }
  return (
    <>
      <header className="header">
        <h1 className="name">Bohemian Harmony Hub</h1>
      </header>

      <main className="main">
        <div className="main-container">
          <h1>bandas</h1>

          {data.map((e) => (
            <p>{e.name}</p>
          ))}
          <table border={1}>
            <tr>
              <th>Banda</th>
              <th>Gênero</th>
              <th>País de origem</th>
              <th>Biografia</th>
            </tr>
          </table>
        </div>
      </main>
          <div className="band-container">
            <div className="band-country"><p>BRAZILZILZIL</p></div>
            <div className="band-name"><p>BANDANOMe</p></div>
            <div className="band-genre"><p>GENRER</p></div>
            <div className="band-bio">oidfasudfashjuidfasdfashkuidfasahuidfasuusldkfjsolefjowijeoijsojisoijoijewofjiewp9ifwojiojifewoji</div>    
            
          </div>

      <footer></footer>
    </>
  );
}

export default App;
