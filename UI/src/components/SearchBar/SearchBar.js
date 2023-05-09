import { useState } from "react";
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import './SearchBar.css';


export function SearchBar(props) {
    const [searchString, setSearchString] = useState("");

    return (
        <>
        <div className="search-bar-container">
            <div className="search-bar-input">
                <Form.Control
                    id="searchString"   
                    value={searchString}
                    onChange={(e) => setSearchString(e.target.value)}
                    type="email" 
                    placeholder="Enter email or name"
                    aria-describedby="searchString"
                    data-testid='search-bar-input-form'
                ></Form.Control>
                <Form.Text id="searchStringHelpBlock">
                    Please enter a minimum of 1 character
                </Form.Text>
            </div>
            <div className="search-bar-button">
                <Button 
                variant="primary" 
                onClick={() => props.onSubmitClicked(searchString)}
                data-testid='search-bar-button'
                >
                    Search
                </Button>
            </div>
        </div>
        </>
    );
}
