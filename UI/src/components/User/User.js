import './User.css';

export function User(props) {
    
    return (
        <>
        <div className="user-item" data-testid={`user-item-${props.index}`}>
            <b>User {props.index + 1 }</b>
            <ul>
                <li><b>Id:</b> {props.id}</li>
                <li><b>First name:</b> {props.firstname}</li>
                <li><b>Surname:</b> {props.surname}</li>
                <li><b>Email:</b> {props.email}</li>
                <li><b>Gender:</b> {props.gender}</li>
            </ul>
        </div>
        </>
    )
}
