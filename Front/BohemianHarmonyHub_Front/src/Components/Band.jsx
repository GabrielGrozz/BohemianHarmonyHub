
function Band(props) {
  return (
    <>

      <div key={props.bandId} className="band-container">
        <div className="band-country">
          <p>{props.countryOfOrigin}</p>
        </div>
        <div className="band-name">
          <p className="band-name-p">{props.name}</p>
        </div>
        <div className="band-genre">
          <p>{props.genre}</p>
        </div>
        <div className="band-bio">{props.bandBiography}</div>
      </div>
   
    </>
  );
}

export default Band;
