import { useState } from "react";

function Band(props) {
  return (
    <>
    <a href="https://google.com" onClick={props.isOpen}>

      <div key={props.bandId} className="band-container">
        <div className="band-country">
          <p>{props.countryOfOrigin}</p>
        </div>
        <div className="band-name">
          <p className="band-name-p">{props.name}</p>
          <div className="band-components">

            <a href="" className="edit-component">editar</a>
            <a href="" className="delete-component">excluir</a>
          </div>
        </div>
        <div className="band-genre">
          <p>{props.genre}</p>
        </div>
        <div className="band-bio">{props.bandBiography}</div>
      </div>
    </a>
    </>
  );
}

export default Band;
