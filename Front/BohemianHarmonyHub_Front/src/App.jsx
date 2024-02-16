import { useState } from "react";
import "./App.css";
import Band from "./Components/Band";
import axios from "axios";
import BandModal from "./Components/Modal/BandModal";

function App() {
  const [data, setData] = useState([]);
  const [bandData, setBandData] = useState("");
  const [bandModalIsOpen, setbandModalIsOpen] = useState(true);

  const url = "https://localhost:7117/Bands/details";

  const req = () =>
    axios.get(url).then((res) => {
      setData(res.data);
      return console.log(res.data);
    });

  function bandClick(e) {
    setBandData(e);
    return console.log("aparentemente funciona   ", bandData);
  }

  return (
    <>
      <button onClick={req}>taotaotao</button>
      <header className="header">
        <h1 className="name">Bohemian Harmony Hub</h1>
      </header>

      <button
        onClick={() => {
          setbandModalIsOpen(!bandModalIsOpen);
          return console.log(bandModalIsOpen);
        }}
      >
        abrirEfecharModal
      </button>

      <BandModal isOpen={bandModalIsOpen} band={bandData} />

      <main className="main">
        <div className="main-container">
          {data.map((res) => (
            <a
              onClick={(e) => {
                e.preventDefault();
                bandClick(res.name);
              }}
              href=""
            >
              <Band
                bandId={res.bandId}
                countryOfOrigin={res.countryOfOrigin}
                name={res.name}
                genre={res.genre}
                bandBiography={res.bandBiography}
              />
            </a>
          ))}
        </div>
      </main>

      <footer></footer>
    </>
  );
}

export default App;
