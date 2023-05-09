import { User } from "../User/User";
import './UserList.css';

export function UserList(props){
    return (
        <>
        <div className="user-list-container">
            {
                props.users &&
                props.users.map((user, index) => (
                    <User
                        index={index}
                        id={user.id}
                        firstname={user.firstname}
                        surname={user.surname}
                        email={user.email}
                        gender={user.gender}
                        data-testid={`user-item-0`}
                    />
                ))
            }
        </div>
        </>
    )
}