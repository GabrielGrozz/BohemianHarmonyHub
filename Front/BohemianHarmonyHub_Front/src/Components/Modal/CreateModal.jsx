import './Modals.css'

function CreateModal(props) {
  if (props.isOpen == true) {
    return (
      <>
        <div className="modals-container">
          <p className='teste'> asopdkasdkado</p>
        </div>
      </>
    );
  }else{
    return(
      <></>
    )
  }
}

export default CreateModal;
