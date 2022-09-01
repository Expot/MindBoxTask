SELECT p.name AS product_name, c.name AS category_name FROM product p
	LEFT JOIN category_product cp ON p.id = cp.product_id 
	LEFT JOIN category AS c ON c.id = cp.category_id;