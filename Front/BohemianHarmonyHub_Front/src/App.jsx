import { useState, useEffect } from "react";
import "./App.css";
import Band from "./Components/Band";
import axios from "axios";

import BandModal from "./Components/Modal/BandModal";
import CreateModal from "./Components/Modal/CreateModal";
import UpdateModal from "./Components/Modal/UpdateModal";
import DeleteModal from "./Components/Modal/DeleteModal";

import trashCan from '../public/trashCan.png'
import pencil from '../public/pencil.png'
function App() {
  const [data, setData] = useState([]);
  const [bandData, setBandData] = useState({});
  const [deleteBandaData , setDeletBandData] = useState({});
  const [bandModalIsOpen, setbandModalIsOpen] = useState(false);
  const [createModalIsOpen, setCreateModalIsOpen] = useState(false);
  const [updateModalIsOpen, setUpdateModalIsOpen] = useState(false);
  const [deleteModalIsOpen, setDeleteModalIsOpen] = useState(false);

  const url = "https://localhost:7117/Bands/details";

  const req = () =>
    axios.get(url).then((res) => {
      setData(res.data);
      return console.log(res.data);
    });

  function bandClick(e) {
    setbandModalIsOpen(!bandModalIsOpen);
    setBandData(e);
    return console.log("aparentemente funciona   ", bandData);
  }

  function updateClick(e){
    setUpdateModalIsOpen(!updateModalIsOpen)
    
  }

  function deleteClick(e){
    setDeleteModalIsOpen(!deleteModalIsOpen)
    setDeletBandData(e)
  }

  function OpenCloseBandModal() {
    setbandModalIsOpen(!bandModalIsOpen);
  }
  function OpenCloseCreateModal() {
    setCreateModalIsOpen(!createModalIsOpen);
  }
  function OpenCloseUpdateModal() {
    setUpdateModalIsOpen(!updateModalIsOpen);
  }
  function OpenCloseDeleteModal() {
    setDeleteModalIsOpen(!deleteModalIsOpen);
  }

  useEffect(() => {
    req();
  }, []);

  return (
    <>
      <header className="header">
        <h1 className="name">Bohemian Harmony Hub</h1>
      </header>

      <BandModal
        isOpen={bandModalIsOpen}
        band={bandData}
        OpenCloseModal={OpenCloseBandModal}
      />
      <CreateModal
        isOpen={createModalIsOpen}
        band={bandData}
        OpenCloseModal={OpenCloseCreateModal}
      />
      <UpdateModal
        isOpen={updateModalIsOpen}
        band={bandData}
        OpenCloseModal={OpenCloseUpdateModal}
      />
      <DeleteModal
        isOpen={deleteModalIsOpen}
        band={deleteBandaData}
        OpenCloseModal={OpenCloseDeleteModal}
      />

      <main className="main">
        <div className="main-container">
          <button className="create-button" onClick={OpenCloseCreateModal}>
            CREATE
          </button>
          {data.map((res) => (
            <div className="band-container-data">
              <a
                className=" band-data-container"
                onClick={(e) => {
                  e.preventDefault();
                  bandClick(res);
                }}
                href=""
              >
                <div className="">
                  <Band
                    isOpen={OpenCloseBandModal}
                    bandId={res.bandId}
                    countryOfOrigin={res.countryOfOrigin}
                    name={res.name}
                    genre={res.genre}
                    bandBiography={res.bandBiography}
                  />
                </div>
              </a>
              <div className="edit-delete-container">
                <a href="" className="edit-link link" onClick={(e) =>{
                  e.preventDefault();
                  updateClick(res)
                }}><img src={pencil} alt="" className="edit-delete-link-image" /></a>
                <a href="" className="delete-link link" onClick={(e) => {
                  e.preventDefault()
                  deleteClick(res)
                }}><img src={trashCan} alt="" className="edit-delete-link-image"/></a>
              </div>
            </div>
          ))}
        </div>
      </main>

      <footer></footer>
    </>
  );
}

export default App;
