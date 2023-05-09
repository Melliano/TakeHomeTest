import Alert from 'react-bootstrap/Alert';


export function ErrorAlert(props) {
    return (
        <>
        { 
            props.showError && 
            <Alert variant="danger" data-testid='search-error-alert'>
                <Alert.Heading>Oh oh! You need to input something!</Alert.Heading>
                <p>{props.errorMessage}</p>
            </Alert> 
        }
        </>
    )
}