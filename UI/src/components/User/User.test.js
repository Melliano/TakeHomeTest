import { render, screen } from '@testing-library/react';
import { User } from "./User";


describe("User tests", () => {
    describe("Shows user", () => {
        beforeEach(() => {
            render(<User 
                index={0} 
                id={1} 
                firstname={'Callum'} 
                surname={'Melia'} 
                email={'who@gmail.com'} 
                gender={'Male'} />)
        })

        it ('should show user details', () => {
            expect(screen.queryByTestId("user-item-0")).toBeInTheDocument();
        })
    })
})