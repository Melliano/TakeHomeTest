import axios from "axios";

export class UserApi {
    static async getUsersBySearchString(searchString){
        const url = `https://localhost:44377/api/User?searchString=${searchString}`;

        return await axios.get(url);
    }
}