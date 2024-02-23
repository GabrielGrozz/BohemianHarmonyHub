import { useEffect, useState } from "react";
import "./Modals.css";

function UpdateModal(props) {
  const [data, setData] = useState({
    BandId: props.band.BandId,
    Name: "",
    Genre: "",
    CountryOfOrigin: "",
    BandBiography: "",
  });

  function handleChange(e) {
    const { name, value } = e.target;
    setBandData({
      ...bandData,
      [name]: value,
    });
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
          </form>
        </div>
      </>
    );
  }
}

export default UpdateModal;
