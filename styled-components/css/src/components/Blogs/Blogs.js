import React, { useEffect, useState } from "react";
import "./Blogs.scss";
import LoadingIndicator from "../LoadingIndicator/LoadingIndicator";
import Button from "../Button/Button";

const Blogs = () => {
  const [isLoading, setLoading] = useState(true);
  const [blogs, setBlogs] = useState([]);

  // Getting Blog Posts
  useEffect(() => {
    setLoading(true);
    setTimeout(() => {
      setBlogs([
        {
          id: "c",
          name: "I ❤️ CSS-IN-JS",
          isOld: false,
          length: 30,
          preview:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
        },
        {
          id: "b",
          name: "CSS-IN-JS - What is it about?",
          isOld: false,
          length: 12,
          preview:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
        },
        {
          id: "a",
          name: "Use CSS in React!!!",
          isOld: true,
          length: 10,
          preview:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
        },
      ]);
      setLoading(false);
    }, 2000);
  }, []);

  return isLoading ? (
    <div className="center-container">
      <LoadingIndicator />
    </div>
  ) : blogs.length === 0 ? (
    <p>No Blog posts.</p>
  ) : (
    <>
      <ul className="blog-list">
        {blogs.map((blog) => (
          <li
            className={`blog-list__item ${
              blog.isOld ? "blog-list__item--old" : ""
            }`}
            key={blog.id}
          >
            <button className="blog">
              <div className="blog__top-row">
                <h2 className="blog__title">{blog.name}</h2>
                <span className="blog__time">{blog.length} min</span>
              </div>

              <p className="blog__preview">{blog.preview}</p>
            </button>
          </li>
        ))}
      </ul>
      <div className="button-row">
        <Button type="secondary" text="Previous" />
        <Button type="primary" text="Next" />
      </div>
    </>
  );
};

export default Blogs;
