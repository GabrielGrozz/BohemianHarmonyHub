import { useState } from "react";
import "./BandModal.css";

function BandModal(props) {
  const [band, setBand] = useState("")
  if (props.isOpen == true) {
    return (
      <>
        <div className="index">
          <div>
            {/* <div className="band-country">
              <p>{props.countryOfOrigin}</p>
            </div> */}
            <div className="band-name">
              <p>{props.name}</p>
            </div>
            {/* <div className="band-genre">
              <p>{props.genre}</p>
            </div>
            <div className="band-bio">
              <p>{props.bandBiography}</p>
            </div> */}
          </div>

          <div>
            <h1>membros</h1>
            {}
          </div>
        </div>
      </>
    );
  } else {
    return <></>;
  }
}

export default BandModal;
