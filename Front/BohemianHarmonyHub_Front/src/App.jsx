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
            <Band
              bandId={e.bandId}
              countryOfOrigin={e.countryOfOrigin}
              name={e.name}
              genre={e.genre}
              bandBiography={e.bandBiography}
              onClick={() => console.log("chegou")}
            />
          ))}
        </div>
      </main>

      <footer></footer>
    </>
  );
}

export default App;
