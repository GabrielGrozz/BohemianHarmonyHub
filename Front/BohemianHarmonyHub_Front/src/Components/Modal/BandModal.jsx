import { useState } from "react";
import "./BandModal.css";

function BandModal(props) {
  if (props.isOpen == true) {
    return (
      <>
        <div className="bandmodal-container">
          <button onClick={() => console.log(props)}>aaa</button>
          <div className="bandmodal-intern-container">
            <div className="band-country">
              <p>{props.band.countryOfOrigin}</p>
            </div>
            <div className="band-name">
              <p>{props.band.name}</p>
            </div>
            <div className="band-genre">
              <p>{props.band.genre}</p>
            </div>
            <div className="band-bio">
              <p>{props.band.bandBiography}</p>
            </div>
          </div>

          <div className="bandmodal-intern-container">
            <h1 className="title">membros</h1>           
              <div className="bandmember-container">
                {props.band.bandMembers.map((e) => (
                  <div className="bandmember">
                    <p className="member-name">{e.name}</p>
                    <p className="dis">{e.role}</p>
                  </div>
                ))}
              </div>            
          </div>
          <div className="bandmodal-intern-container">
            <h1 className="title">Principais álbuns</h1>
            <div className="album-container">
              {props.band.discography.map((e) => (
                <div className="album">
                  <div className="black-square"></div>
                  <div className="info-container">
                    <p className="album-title">{e.title}</p>
                    <p className="album-releaseYear">{e.releaseYear}</p>
                  </div>
                </div>
              ))}
            </div>
          </div>
        </div>
      </>
    );
  } else {
    return <></>;
  }
}

export default BandModal;
