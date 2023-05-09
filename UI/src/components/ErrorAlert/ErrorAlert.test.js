import { render, screen } from '@testing-library/react';
import { ErrorAlert } from "./ErrorAlert";


describe("Error alert tests", () => {
    describe("Show error", () => {
        beforeEach(() => {
            render(<ErrorAlert showError={true} errorMessage={"Test Error"} />)
        })

        it ('should show error when true', () => {
            expect(screen.queryByTestId("search-error-alert")).toBeInTheDocument();
        })
    })

    describe("Hide error", () => {
        beforeEach(() => {
            render(<ErrorAlert showError={false} errorMessage={"Test Error"} />)
        })

        it ('should not show error when false', () => {
            expect(screen.queryByTestId("search-error-alert")).toBeFalsy();
        })
    })
})