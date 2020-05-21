import React from "react";
import styled, { keyframes } from "styled-components";

const Container = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
`;

const RingAnimation = keyframes`
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
`;

function SpinColorsAnimation(props) {
  return keyframes`
 	0% { border-color: blue transparent transparent transparent; }
	25% {  border-color: purple transparent transparent transparent; }
	50% {  border-color: red transparent transparent transparent; }
	75% {  border-color: purple transparent transparent transparent; }
  100% {  border-color: blue transparent transparent transparent; }
`;
}

const LoadingRing = styled.div`
  display: inline-block;
  position: relative;
  height: 80px;
  width: 80px;

  div {
    box-sizing: border-box;
    display: block;
    position: absolute;
    width: 64px;
    height: 64px;
    margin: 8px;
    border: 8px solid #fff;
    border-radius: 50%;
    animation: ${RingAnimation} 1.2s cubic-bezier(0.5, 0, 0.5, 1) infinite,
      ${SpinColorsAnimation} 4.8s ease-in-out infinite;
    border-color: #fff transparent transparent transparent;
  }

  div:nth-child(1) {
    animation-delay: -0.45s;
  }
  div:nth-child(2) {
    animation-delay: -0.3s;
  }
  div:nth-child(3) {
    animation-delay: -0.15s;
  }
`;

const LoadingIndicator = () => {
  return (
    <Container>
      <LoadingRing>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
      </LoadingRing>
    </Container>
  );
};

export default LoadingIndicator;
