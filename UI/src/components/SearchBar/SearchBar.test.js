import { fireEvent, render, screen } from '@testing-library/react';
import { SearchBar } from "./SearchBar";


describe("Search bar", () => {
    const onSubmitClickedMock = jest.fn();

    beforeEach(() => {
        render(
            <SearchBar onSubmitClicked={onSubmitClickedMock}></SearchBar>
        )
    })

    afterEach(() => {
        jest.clearAllMocks();
    })

    it ('should be empty on initial load', () => {
        expect(screen.getByTestId("search-bar-input-form")).toBeInTheDocument();
        expect(screen.getByTestId("search-bar-button")).toBeInTheDocument();
        expect(screen.getByTestId("search-bar-input-form")).toHaveValue("");
    })

    it ('should call onSubmitClicked when search button is clicked', () => {
        fireEvent.click(screen.getByTestId("search-bar-button"));
        expect(onSubmitClickedMock).toBeCalled();
    })
})