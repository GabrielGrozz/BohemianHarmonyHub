import { useEffect, useState } from "react";
import "./Modals.css";

function CreateModal(props) {
  const [bandData, setBandData] = useState({
    BandId: "",
    Name: "",
    Genre: "",
    CountryOfOrigin: "",
    BandBiography: "",
  });

  function HandleChange(e) {
    setBandData(e);
    return console.log(bandData);
  }

  useEffect(() => {
    HandleChange();
  }, [HandleChange]);

  if (props.isOpen == true) {
    return (
      <>
        <div className="modals-container">
          <form action="">
            <div className="form-field">
              <label htmlFor="name">Nome</label>
              <input
                type="text"
                id="name"
                onChange={(e) => HandleChange(e.target.value)}
                required
                placeholder="nome da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="genre">Gênero</label>
              <input
                type="text"
                id="genre"
                onChange={(e) => HandleChange(e.target.value)}
                required
                placeholder="gênero musical da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="country-of-origin">País de origem</label>
              <input
                type="text"
                id="country-of-origin"
                onChange={(e) => HandleChange(e.target.value)}
                required
                placeholder=" país de origem da banda"
              />
            </div>
            <div className="form-field">
              <label htmlFor="band-biography">Biografia da banda</label>
              <input
                type="text"
                id="band-biography"
                onChange={(e) => HandleChange(e.target.value)}
                required
                placeholder=" biografia da banda"
              />
            </div>

            <button type="submit">Criar</button>
          </form>
        </div>
      </>
    );
  } else {
    return <></>;
  }
}

export default CreateModal;
