import { useEffect, useState } from "react";
import { UserApi } from "../../apis/user.api";
import { ErrorAlert } from "../ErrorAlert/ErrorAlert";
import { SearchBar } from "../SearchBar/SearchBar";
import { UserList } from "../UserList/UserList";
import './UserSearch.css';




export function UserSearch() {
    const [submitClicked, setSubmitClicked] = useState(false);
    const [searchQuery, setSearchQuery] = useState("");
    const [users, setUsers] = useState([]);
    const [showError, setShowError] = useState(false);
    const [errorMessage, setErrorMessage] = useState("");

    useEffect(() => {
        if (submitClicked){
          UserApi.getUsersBySearchString(searchQuery)
          .then((response) => {
            setUsers(response.data);
            setShowError(false);
          })
          .catch((error) => {
            setShowError(true);
            setErrorMessage(error.response.data);
          });
          setSubmitClicked(false);
        }
      }, [submitClicked])
    
      function handleSubmitClicked(searchString) {
        setSubmitClicked(true);
        setSearchQuery(searchString);
      }

    return (
        <>
            <div className='search-bar'>
                <SearchBar onSubmitClicked={handleSubmitClicked}/>
            </div>
            {
                showError 
                    ? <ErrorAlert showError={showError} errorMessage={errorMessage}/>
                    : <UserList users={users}/>
            }
        </>
    )
}