import { useEffect, useState } from "react";
import axios from "axios";
import "./Modals.css";

const url = "https://localhost:7117/Bands";


function CreateModal(props) {
  const [data, setData] = useState([])
  const [bandData, setBandData] = useState({
    BandId: "",
    Name: "",
    Genre: "",
    CountryOfOrigin: "",
    BandBiography: "",
  });

  async function Bandpost(e) {
    delete bandData.BandId;
  
    await axios.post(url, bandData).then((res) => {
      setData(data.concat(res.data));
    });
  }

  const handleChange = (e) => {
    const { name, value } = e.target;
    setBandData({
      ...bandData,
      [name]: value,
    });
    return console.log(name, value);
  };

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
              required
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
              required
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
              required
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
              required
              placeholder=" biografia da banda"
            />
          </div>

          <button type="submit" onClick={Bandpost}>Criar</button>
        </form>
      </div>
    </>
  );
}

export default CreateModal;
