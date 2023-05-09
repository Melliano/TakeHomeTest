import { fireEvent, render, screen } from '@testing-library/react';
import { UserSearch } from "./UserSearch";


describe("Loads user search", () => {
    beforeEach(() => {
        render(<UserSearch/>)
    })

    it('should show error when clicked with no search string', () => {
        const searchBarButton = screen.getByTestId("search-bar-button");
        fireEvent.click(searchBarButton);
        expect()
    })
})