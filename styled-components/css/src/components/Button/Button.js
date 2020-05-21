import React from "react"
import "./Button.scss";

const Button = ({
    text,
    onClick,
    type
}) => {
    return (
        <button onClick={onClick} className={`btn btn--${type}`}>
            {text}
        </button>
    )
}

export default Button