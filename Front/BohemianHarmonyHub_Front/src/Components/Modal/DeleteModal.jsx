import './Modals.css'
import axios from 'axios'

function DeleteModal(props) {
  const deleteUrl = `https://localhost:7117/Bands/${props.band.bandId}`;

  async function deleteReq(){
    await axios.delete(deleteUrl)
  }

  if (props.isOpen == true) {
    return (
      <>
        <div className="modals-container">
          <p>TEM CERTEZA QUE QUER DELETAR A BANDA <strong>{props.band.name} </strong>?</p>
          <div className='delete-options'>
            <a href="" className='delete-option option' onClick={deleteReq}>deletar</a>
            <a href="" className='cancel-option option'>cancelar</a>
          </div>
        </div>
      </>
    );
  }
}

export default DeleteModal;
