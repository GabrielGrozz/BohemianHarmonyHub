import { useEffect, useState } from "react";
import "./Modals.css";
import axios from "axios";

function UpdateModal(props) {
  const url = `https://localhost:7117/Bands/${props.band.bandId}`;

  const [bandData, setBandData] = useState({
    BandId: "",
    Name: "",
    Genre: "",
    CountryOfOrigin: "",
    BandBiography: "",
  });

  async function updateBand() {
    setBandData({
      ...bandData,
      BandId: props.band.bandId
    })
    await axios.put(url, bandData);
    return console.log(bandData)
  }

  function handleChange(e) {
    const { name, value } = e.target;
    setBandData({
      ...bandData,
      [name]: value,
    });
    return console.log(bandData);
  }

  if (props.isOpen == true) {
    return (
      <>
        <div className="modals-container">
          <form>
            <div className="form-field">
              <label htmlFor="name">Nome</label>
              <input
                type="text"
                id="name"
                name="Name"
                onChange={handleChange}
                placeholder="nome da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="genre">Gênero</label>
              <input
                type="text"
                id="Genre"
                name="Genre"
                onChange={handleChange}
                placeholder="gênero musical da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="country-of-origin">País de origem</label>
              <input
                type="text"
                id="country-of-origin"
                name="CountryOfOrigin"
                onChange={handleChange}
                placeholder=" país de origem da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="band-biography">Biografia da banda</label>
              <input
                type="text"
                id="band-biography"
                name="BandBiography"
                onChange={handleChange}
                placeholder=" biografia da banda"
              />
            </div>

            <div>
              <button type="submit" onClick={(e) => {
                e.preventDefault()
                console.log(props.band.bandId)
                updateBand()
              }}>
                Atualizar dados
              </button>
            </div>
          </form>
        </div>
      </>
    );
  }
}

export default UpdateModal;
