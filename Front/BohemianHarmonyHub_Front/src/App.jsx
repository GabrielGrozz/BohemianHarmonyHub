import { useState } from "react";
import "./App.css";
import Band from "./Components/Band";
import axios from "axios";
import BandModal from "./Components/Modal/BandModal";

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
      <button onClick={req}>taotaotao</button>
      <header className="header">
        <h1 className="name">Bohemian Harmony Hub</h1>
      </header>
      <BandModal/>
      <main className="main">
        <div className="main-container">
          {data.map((e) => (
            <div key={e.bandId} className="band-container">
              <div className="band-country">
                <p>{e.countryOfOrigin}</p>
              </div>
              <div className="band-name">
                <p>{e.name}</p>
              </div>
              <div className="band-genre">
                <p>{e.genre}</p>
              </div>
              <div className="band-bio">{e.bandBiography}</div>
            </div>
          ))}
        </div>
      </main>

      <footer></footer>
    </>
  );
}

export default App;
